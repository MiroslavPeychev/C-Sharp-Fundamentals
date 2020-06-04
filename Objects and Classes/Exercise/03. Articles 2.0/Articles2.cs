﻿namespace _03._Articles_2._0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Articles2
    {
        public static void Main()
        {
            int articleCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articleCount; i++)
            {
                string[] splittedInput = Console.ReadLine().Split(", ");

                string title = splittedInput[0];
                string content = splittedInput[1];
                string author = splittedInput[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string orderBy = Console.ReadLine();

            if (orderBy == "title")
            {
                articles = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (orderBy == "content")
            {
                articles = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else if (orderBy == "author")
            {
                articles = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}