using System;
using System.Collections.Generic;

namespace GetDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f");
            while (true)
            {
                Console.WriteLine("\nWrite number");
                string length = Console.ReadLine();
                bool success = Int32.TryParse(length, out int lengthInt);
                if (success == false)
                {
                    Console.WriteLine("\nNot valid number, click Enter to try again.");
                    Console.ReadLine();
                }
                else if(success == true)
                {
                    int[] nums = GetDivide(lengthInt);
                    foreach (int item in nums)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
        }
        static int[] GetDivide(int length)
        {
            List<int> divideList = new List<int>();
            for (int i = 0; i < length; i++)
            {
                if (i % 3 == 0)
                {
                    divideList.Add(i);
                }
            }
            int[] array = divideList.ToArray();
            return array;
        }

    }
}
