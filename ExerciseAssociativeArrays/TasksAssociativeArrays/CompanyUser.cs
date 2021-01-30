using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class CompanyUser
    {
        public void TaskCompanyUser()
        {
            var companyDict = new Dictionary<string, List<string>>();

            while (true)
            {
                var company = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                if (company[0] == "End")
                    break;

                if (!companyDict.ContainsKey(company[0]))
                {
                    companyDict[company[0]] = new List<string>();
                    companyDict[company[0]].Add(company[1]);
                }
                else
                {
                    if (!companyDict[company[0]].Contains(company[1]))
                    {
                        companyDict[company[0]].Add(company[1]);
                    }
                }
            }

            companyDict = companyDict.OrderBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);

            foreach (var company in companyDict.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
