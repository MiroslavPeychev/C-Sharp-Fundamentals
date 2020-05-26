namespace _05._Bomb_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class BombNumbers
    {
        public static void Main()
        {
            // ToDo
            //Read Numbers
            //Read Bomb Numbers
            //Find Bomb Number index
            //Explosion
            //Sum
            //Print

            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNumber = bombNumbers[0];
            int range = bombNumbers[1];

            int bombIndex = nums.IndexOf(bombNumber);

            while (bombIndex != -1)
            {
                int leftIndex = bombIndex - range;
                int rightIndex = bombIndex + range;

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                if (rightIndex > nums.Count - 1)
                {
                    rightIndex = nums.Count - 1;
                }

                int count = rightIndex - leftIndex + 1;

                nums.RemoveRange(leftIndex, count);

                bombIndex = nums.IndexOf(bombNumber);
            }

            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}


