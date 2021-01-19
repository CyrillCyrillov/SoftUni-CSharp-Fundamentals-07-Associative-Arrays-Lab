using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            SortedDictionary<double, int> countsNumbers = new SortedDictionary<double, int>();

            foreach (double nextNumber in numbers)
            {
                if(countsNumbers.ContainsKey(nextNumber))
                {
                    countsNumbers[nextNumber]++;
                }
                else
                {
                    countsNumbers.Add(nextNumber, 1);
                }
            }

            foreach (var item in countsNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
