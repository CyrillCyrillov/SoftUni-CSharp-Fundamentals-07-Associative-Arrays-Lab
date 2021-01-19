using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (string nextWord in words)
            {
                string lowCaseNextWor = nextWord.ToLower();
                if(countWords.ContainsKey(lowCaseNextWor))
                {
                    countWords[lowCaseNextWor]++;
                }
                else
                {
                    countWords.Add(lowCaseNextWor, 1);
                }
            }

            foreach (var keyWord in countWords)
            {
                if(keyWord.Value % 2 != 0)
                {
                    Console.Write($"{keyWord.Key} ");
                }
            }
        }
    }
}
