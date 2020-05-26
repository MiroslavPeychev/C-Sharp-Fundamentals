namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class PokemonDoNotGo
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;// сумата която ще принтираме накрая
            int index = 0;//индекс-а, който ни се дава от конзолата
            int current = 0;// помощна величина, която ни помага да си трием каквото си поискаме и да помним каквото ни трябва

            while (sequence.Count > 0)// докато има членове в sequence прави
            {
                index = int.Parse(Console.ReadLine());// парсваме си индекса като число

                if (index < 0)//ако индекса е по-малък от нула
                {
                    current = sequence[0];// текущия става равен на нулевият елемент.
                    sequence.RemoveAt(0);//премахваме го
                    sequence.Insert(0, sequence[sequence.Count - 1]);// добавяме на нулевата поиция  последният елемент 
                }
                else if (index >= sequence.Count)// когато индексът е по-голям от дължината на sequence
                {
                    current = sequence[sequence.Count - 1];// текущия става равен на последният елемент.
                    sequence.RemoveAt(sequence.Count - 1);//премахваме последния елемент
                    sequence.Add(sequence[0]);// на негово място слагаме първият елемент.
                }
                else// когато индексът е реален(има такива елементи)
                {
                    current = sequence[index];//текущия става равен на елемента който е на индекса
                    sequence.RemoveAt(index);//премахваме този елемент
                }

                for (int i = 0; i < sequence.Count; i++)// проверяваме всеки останал елемент от sequence
                {
                    if (sequence[i] <= current)// ако е по малък или равен го увеличаваме с current
                    {
                        sequence[i] += current;
                    }
                    else
                    {
                        sequence[i] -= current; //ако е по-малък го намаляваме с current
                    }
                }

                sum += current;// към сумата прибавяме current
            }

            Console.WriteLine(sum);// принтираме сумата

        }
    }
}