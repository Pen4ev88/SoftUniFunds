using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class HouseParty
    {
        public void TaskHouseParty()
        {
            var personList = new List<string>();
            var exeptionList = new List<string>();

            var personData = int.Parse(Console.ReadLine());

            for (int i = 0; i < personData; i++)
            {
                var personComming = Console.ReadLine();

                if (personComming.Contains("is going"))
                {
                    var personInfo = personComming.Split(" ");

                    if (personList.Contains(personInfo[0]))
                    {
                        exeptionList.Add($"{personInfo[0]} is already in the list!");
                        continue;
                    }

                    personList.Add(personInfo[0]);
                }
                else //not going
                {
                    var personInfo = personComming.Split(" ");

                    if (!personList.Contains(personInfo[0]))
                    {
                        exeptionList.Add($"{personInfo[0]} is not in the list!");
                        continue;
                    }

                    personList.Remove(personInfo[0]);
                }
            }
            for (int i = 0; i < exeptionList.Count; i++)
            {
                Console.WriteLine($"{exeptionList[i]}");
            }

            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine($"{personList[i]}");
            }
        }
    }
}
