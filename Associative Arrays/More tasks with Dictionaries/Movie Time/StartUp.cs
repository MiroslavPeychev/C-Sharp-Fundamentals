namespace Movie_Time
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;

    public class StartUp
    {
        private const string TimeFormat = @"hh\:mm\:ss";
        public static void Main(string[] args)
        {
            string favGenre = Console.ReadLine();
            string favDuration = Console.ReadLine();

            var myDict = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "POPCORN!")
                {
                    break;
                }

                var tokens = input.Split('|');

                string name = tokens[0];
                string genre = tokens[1];
                string duration = tokens[2];


                if (!myDict.ContainsKey(genre))
                {
                    myDict[genre] = new Dictionary<string, string>();
                }
                myDict[genre][name] = duration;
            }

            var array = new List<KeyValuePair<string, string>>();

            if (favDuration == "Short")
            {
                array = myDict[favGenre].OrderBy(x => x.Value).ToList();
            }
            else if (favDuration == "Long")
            {
                array = myDict[favGenre].OrderByDescending(x => x.Value).ToList();
            }

            int i = -1;

            while (true)
            {
                string input = Console.ReadLine();
                i++;
                var currentMovie = array[i].Key;
                var currentTime = array[i].Value;

                    Console.WriteLine($"{currentMovie}");
                if (input == "Yes")
                {
                    Console.WriteLine($"We're watching {currentMovie} - {currentTime}");
                    break;
                }
                
                
            }

            TimeSpan sum = TimeSpan.Zero;
            var sumAdd = new List<TimeSpan>();

            foreach (var item in myDict)
            {
                foreach (var kvp in item.Value)
                {
                    string currentTime = kvp.Value;
                    TimeSpan time = TimeSpan.ParseExact(currentTime, TimeFormat, CultureInfo.InvariantCulture);
                    sumAdd.Add(time);

                }
            }

            var totalSpan = new TimeSpan(sumAdd.Sum(r => r.Ticks));
            Console.WriteLine($"Total Playlist Duration: {totalSpan}");
        }
    }
}