using System;
using System.Linq;


namespace Task03_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersToSort = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            numbersToSort = numbersToSort.OrderByDescending(x => x).ToArray();

            if(numbersToSort.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbersToSort[i]} ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbersToSort));
            }
        }
    }
}
