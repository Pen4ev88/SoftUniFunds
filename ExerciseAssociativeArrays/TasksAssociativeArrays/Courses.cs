using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class Courses
    {
        public void TaskCourses()
        {
            var courcesDict = new Dictionary<string, List<string>>();
            string[] cource = new string[2];

            do
            {
                cource = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();

                if (cource[0] == "end")
                    break;

                if (!courcesDict.ContainsKey(cource[0]))
                {
                    courcesDict[cource[0]] = new List<string>();
                    courcesDict[cource[0]].Add(cource[1]);
                }
                else
                {
                    courcesDict[cource[0]].Add(cource[1]);
                }

            }
            while (true);

            var courceDictFinal = courcesDict.Select(c => c)
                                             .OrderByDescending(c => c.Value.Count())
                                             .ToDictionary(c => c.Key, c => c.Value);

            foreach (var kvp in courceDictFinal)
            {
                Console.Write($"{kvp.Key}: {kvp.Value.Count()}\n");
                foreach (var item in kvp.Value.OrderBy(n => n))
                {
                    Console.Write($"-- {item}\n");
                }
            }
        }
    }
}
