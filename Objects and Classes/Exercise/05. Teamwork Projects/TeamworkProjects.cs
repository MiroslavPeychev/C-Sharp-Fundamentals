namespace _05._Teamwork_Projects
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TeamworkProjects
    {
        public static void Main()
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] splittedInput = Console.ReadLine().Split('-');

                string creatorName = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamNameExist = teams.Select(x => x.Name).Contains(teamName);
                //bool isTeamNameExist = teams.Any(x => x.Name == teamName);
                bool isCreatorNameExist = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamNameExist == false && isCreatorNameExist == false)
                {
                    Team team = new Team(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNameExist)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] splittedInput = input.Split("->");

                string user = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamExist = teams.Any(x => x.Name == teamName);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user) || x.CreatorName == user);

                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                if (isTeamExist && isAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Members.Add(user);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();

            List<Team> teamsWithoutMembers = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (Team team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.CreatorName);
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.OrderBy(x => x).Select(x => $"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsWithoutMembers)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {

        public Team(string name, string creatorName)
        {
            this.Name = name;
            this.CreatorName = creatorName;
            this.Members = new List<string>();
        }

        public string Name { get; private set; }

        public string CreatorName { get; private set; }

        public List<string> Members { get; private set; }
    }
}