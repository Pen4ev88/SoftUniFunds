using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class StudentAcademy
    {
        public void TaskStudentAcademy()
        {
            var studentDict = new Dictionary<string, List<double>>();

            var students = int.Parse(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (!studentDict.ContainsKey(name))
                {
                    studentDict[name] = new List<double>();
                    //studentDict[name].Add(grade);
                }
                studentDict[name].Add(grade);
            }

            Console.WriteLine(string.Join("\n", studentDict
                                   .Where(s => (s.Value.Sum() / s.Value.Count) >= 4.5)
                                   .OrderByDescending(s => s.Value.Sum() / s.Value.Count)
                                   .Select(s => $"{s.Key} -> {s.Value.Sum() / s.Value.Count():F2}")));
        }
    }
}
