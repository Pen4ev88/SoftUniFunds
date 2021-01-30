using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class CountChar
    {
        public void TaskCountChar()
        {
            var chars = Console.ReadLine().ToList();

            var dictChars = new Dictionary<char, int>();

            foreach (var ch in chars)
            {
                if (!dictChars.ContainsKey(ch))
                {
                    dictChars[ch] = 0;
                }

                dictChars[ch]++;
            }

            foreach (var kvp in dictChars)
            {
                if (kvp.Key != ' ')
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
