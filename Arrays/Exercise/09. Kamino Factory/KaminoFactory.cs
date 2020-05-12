namespace _09._Kamino_Factory
{
    using System;
    using System.Linq;

    public class KaminoFactory
    {
        public static void Main()
        {
            int DNALength = int.Parse(Console.ReadLine());
            int sequenceLength = 0;
            int sumElements = 0;
            int startIndex = -1;
            int row = 0;
            int currentRow = 1;
            int[] DNA = new int[DNALength];

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = inputLine
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSum = 0;

                for (int i = 0; i < DNALength; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }

                if (currentRow == 1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sumElements = currentSum;
                }

                int currentStartIndex = -1;
                int currentLength = 0;
                bool isFound = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }

                        currentLength++;

                        if (currentLength > sequenceLength)
                        {
                            sequenceLength = currentLength;
                            startIndex = currentStartIndex;
                            sumElements = currentSum;
                            row = currentRow;
                            DNA = currentDNA;
                        }
                        else if (currentLength == sequenceLength)
                        {
                            if (currentStartIndex < startIndex)
                            {
                                sequenceLength = currentLength;
                                startIndex = currentStartIndex;
                                sumElements = currentSum;
                                row = currentRow;
                                DNA = currentDNA;
                            }
                        }
                        else if (currentSum > sumElements)
                        {
                            sequenceLength = currentLength;
                            startIndex = currentStartIndex;
                            sumElements = currentSum;
                            row = currentRow;
                            DNA = currentDNA;
                        }
                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentLength = 0;
                        isFound = false;
                    }
                }

                currentRow++;
            }

            Console.WriteLine($"Best DNA sample {row} with sum: {sumElements}.");
            Console.WriteLine(string.Join(" ", DNA));

        }
    }
}