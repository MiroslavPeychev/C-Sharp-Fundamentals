namespace _08._Anonymous_Threat
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AnonymusThreat
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                 .Split(' ')
                 .ToList();
            string[] command = Console.ReadLine()
                 .Split(' ')
                 .ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int start = int.Parse(command[1]);
                    int end = int.Parse(command[2]);

                    if (start < 0)// ако индексът който ни е зададен е извън масива(невалиден е) то трябва да вземем само валидните индекси(ако е от -1 до 5, взимаме само от 0 до 5)
                    {
                        start = 0;
                    }
                    if (end >= words.Count)
                    {
                        end = words.Count - 1;//същото като горното 
                    }
                    for (int i = start; i < end; i++)
                    {
                        words[start] = words[start] + words[start + 1];// мърджваме елементите 
                        words.RemoveAt(start + 1);// този, който сме го мърджнали го премахваме, за да не се появи пак и каунта се намалява с 1 ца
                    }

                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    int numberOfLetters = words[index].Length / partitions;//пази колко букви ще има в един член след разделянето (без последния елемент ако е нечетно)
                    string current = words[index];
                    List<string> divided = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        divided.Add(current.Substring(0, numberOfLetters));//
                        current = current.Remove(0, numberOfLetters);
                    }

                    divided[divided.Count - 1] = divided[divided.Count - 1] + current;
                    words.RemoveAt(index);
                    words.InsertRange(index, divided);
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}