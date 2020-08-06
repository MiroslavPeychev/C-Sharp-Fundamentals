
namespace MeTube_Statistics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var videoAndViews = new Dictionary<string, int>();
            var videoAndLikesOrDislikes = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stats time")
                {
                    break;
                }

                if (input.Contains('-'))
                {
                    string[] tokens = input.Split("-");
                    string videoName = tokens[0];
                    int views = int.Parse(tokens[1]);

                    if (!videoAndViews.ContainsKey(videoName))
                    {
                        videoAndViews[videoName] = 0;
                    }
                    videoAndViews[videoName] += views;

                    if (!videoAndLikesOrDislikes.ContainsKey(videoName))
                    {
                        videoAndLikesOrDislikes[videoName] = 0;
                    };
                }
                else if (input.Contains(':'))
                {
                    string[] tokens = input.Split(":");
                    string likeOrDislike = tokens[0];
                    string videoName = tokens[1];

                    if (likeOrDislike == "like")
                    {
                        if (videoAndLikesOrDislikes.ContainsKey(videoName))
                        {
                            videoAndLikesOrDislikes[videoName] += 1;
                        }
                    }
                    else if (likeOrDislike == "dislike")
                    {
                        if (videoAndLikesOrDislikes.ContainsKey(videoName))
                        {
                            videoAndLikesOrDislikes[videoName] -= 1;
                        }
                    }
                }
            }

            string command = Console.ReadLine();

            if (command == "by views")
            {
                foreach (var kvp in videoAndViews.OrderByDescending(x => x.Value))
                {
                    long likes = videoAndLikesOrDislikes[kvp.Key];

                    Console.WriteLine($"{kvp.Key} - {kvp.Value} views - {likes} likes");
                }
            }
            else if (command == "by likes")
            {
                foreach (var kvp in videoAndLikesOrDislikes.OrderByDescending(x => x.Value))
                {
                    int views = videoAndViews[kvp.Key];
                    Console.WriteLine($"{kvp.Key} - {views} views - {kvp.Value} likes");
                }
            }
        }
    }
}