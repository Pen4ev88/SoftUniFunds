using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniFunds.AssociativeArrays
{
    public class Labs
    {
        public void CountOdd()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            var numDict = new SortedDictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!numDict.ContainsKey(number))
                {
                    numDict[number] = 0;
                }
                numDict[number]++;
            }

            foreach (var num in numDict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }

        public void OddNumber()
        {
            string[] words = Console.ReadLine()
                .Split().ToArray()
                .Select(w => w.ToLower())
                .ToArray();

            var wordDict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                 word.ToLower();
                if(!wordDict.ContainsKey(word))
                {
                    wordDict[word] = 0;
                }

                wordDict[word]++;
            }

            foreach (var kvp in wordDict)
            {                 
                if (kvp.Value %2 != 0)
                { 
                   Console.Write($"{kvp.Key} "); 
                }
            }
        }

        public void Synonyms()
        {
            var numbers = int.Parse(Console.ReadLine());

            var synonymDict = new SortedDictionary<string, List<string>>();

            for (int i = 0; i < numbers; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if (!synonymDict.ContainsKey(word))
                {
                    synonymDict[word] = new List<string>();
                }

                synonymDict[word].Add(synonym);
            }

            foreach (var kvp in synonymDict)
            {
                var word = kvp.Key;
                var synonyms = kvp.Value;
                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }

        public void Largest3()
        {
            var integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(ii => ii)
                .ToList()
                .Take(3);                

            foreach (var item in integers)
            {
                Console.Write($"{item} ");            
            }            
        }

        public void WordFilter()
        {
            var fruts = Console.ReadLine()
                .Split()
                .Where(f => f.Length % 2 == 0)
                .ToArray();

            foreach (var frut in fruts)
            {
                Console.WriteLine(frut);
            }
                
        }
    }
}
