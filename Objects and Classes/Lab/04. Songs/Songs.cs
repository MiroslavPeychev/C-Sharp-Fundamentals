namespace _04._Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Songs
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            List<Song> filteredSongs = songs
                .Where(s => s.TypeList == typeList)
                .ToList();

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }
        }

        public class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
    }
}