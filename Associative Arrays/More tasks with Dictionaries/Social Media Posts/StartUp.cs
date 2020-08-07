namespace Social_Media_Posts
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var posts = new Dictionary<string, Dictionary<string, int>>();
            var comments = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "drop the media")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];
                string post = tokens[1];
                
                if (command == "post")
                {
                    if (!posts.ContainsKey(post))
                    {
                        posts.Add(post, new Dictionary<string, int>());
                        posts[post].Add("Likes:", 0);
                        posts[post].Add("Dislikes:", 0);
                    }
                }
                else if (command == "like")
                {                   
                        posts[post]["Likes:"]++;                    
                }
                else if (command == "dislike")
                {
                    posts[post]["Dislikes:"]++;
                }
                else if (command == "comment")
                {
                    string commentator = tokens[2];                    
                    
                    if(!comments.ContainsKey(post))
                    {
                        comments.Add(post, new Dictionary<string, List<string>>());
                    }

                    comments[post].Add(commentator, new List<string>());

                    for (int i = 3; i < tokens.Length; i++)
                    {
                        comments[post][commentator].Add(tokens[i]); 
                    }
                }
            }

            foreach (var kvp in posts)
            {
                string postName = kvp.Key;
                Console.Write($"Post: {postName}");

                foreach (var item in kvp.Value)
                {
                    Console.Write($" | {item.Key} {item.Value}");
                }

                Console.WriteLine();
                Console.WriteLine("Comments:");

                if(comments.ContainsKey(kvp.Key))
                {
                    var com = comments[kvp.Key];

                    foreach (var item in com)
                    {
                        Console.WriteLine($"*  {item.Key}: {string.Join(" ", item.Value)}");
                    }
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}