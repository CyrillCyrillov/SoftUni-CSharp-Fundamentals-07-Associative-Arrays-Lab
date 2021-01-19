using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= number; i++)
            {
                string nextWord = Console.ReadLine();
                string nextSynonym = Console.ReadLine();

                if(synonyms.ContainsKey(nextWord))
                {
                    synonyms[nextWord].Add(nextSynonym);
                }
                else
                {
                    synonyms.Add(nextWord, new List<string>());
                    synonyms[nextWord].Add(nextSynonym);
                }
            }

            foreach (var element in synonyms)
            {
                Console.Write($"{element.Key} - ");
                Console.WriteLine(string.Join(", ", (element.Value)));
            }
        }
    }
}
