using System;
using System.Linq;

namespace Task05_Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToSelect = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


            string[] filteredWords = wordsToSelect.Where(x => x.Length % 2 == 0).ToArray();
            
            Console.WriteLine(string.Join((char)10, filteredWords));
        }
    }
}
