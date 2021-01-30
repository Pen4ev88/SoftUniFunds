using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class SoftUniExam
    {
        public void TaskSoftUniExam()
        {
            var resultExam = new Dictionary<string, List<int>>();

            var submission = new SortedDictionary<string, int>();

            var langDict = new SortedDictionary<string, int>();

            while (true)
            {
                bool ban = false;

                var input = Console.ReadLine();

                if (input == "exam finished")
                    break;

                var studentRes = input.Split("-");
                var nameLang = studentRes[0];
                string lang = "";
                int grade = 0;

                if (!input.Contains("banned"))
                {
                    lang = studentRes[1];
                    grade = int.Parse(studentRes[2]);

                    if (!resultExam.ContainsKey(nameLang))
                    {
                        resultExam[nameLang] = new List<int>();
                        resultExam[nameLang].Add(grade);
                    }
                    else
                    {
                        resultExam[nameLang].Add(grade);
                    }

                    if (!langDict.ContainsKey(lang))
                    {
                        langDict[lang] = 1;
                    }
                    else
                    {
                        langDict[lang]++;
                    }

                }
                else
                {
                    ban = true;

                    foreach (var item in resultExam.Where(kvp => kvp.Key.StartsWith(studentRes[0])).ToList())
                    {
                        resultExam.Remove(item.Key);
                    }
                }
            }

            var resultMax = new SortedDictionary<string, int>();
            foreach (var user in resultExam)
            {
                if (!resultMax.ContainsKey(user.Key))
                {
                    resultMax[user.Key] = user.Value.Select(s => s).Max();
                }
            }

            Console.WriteLine("Results:");

            var resultMaxF = resultMax.OrderByDescending(r => r.Value).ToDictionary(r => r.Key, r => r.Value);

            foreach (var user in resultMaxF)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var l in langDict)
            {
                Console.WriteLine($"{l.Key} - {l.Value}");
            }

        }
    }
}
