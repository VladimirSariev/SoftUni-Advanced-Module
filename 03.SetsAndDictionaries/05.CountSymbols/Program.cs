using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (dictionary.ContainsKey(word[i]))
                {
                    dictionary[word[i]]++;
                    
                }
                else
                {
                    dictionary.Add(word[i], 1);
                }
            }

            foreach (var letter in dictionary)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
