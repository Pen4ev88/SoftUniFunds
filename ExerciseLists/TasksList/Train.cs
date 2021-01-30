using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.Tasks
{
    public class Train
    {
        public void TaskTrain()
        {
            var trains = new List<int>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                trains.Add(int.Parse(item));
            }

            var maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                var passanger = Console.ReadLine();

                if (passanger == "end")
                    break;

                if (passanger.Contains("Add"))
                {
                    var addTrain = passanger.Split(" ");

                    trains.Add(int.Parse(addTrain[1]));
                }
                else
                {
                    var passangers = int.Parse(passanger);
                    int restPass = 0;

                    for (int i = 0; i < trains.Count; i++)
                    {
                        restPass = maxCapacity - (trains[i] + passangers);

                        if (restPass >= 0)
                        {
                            trains[i] += passangers;
                            restPass = 0;
                            break;
                        }

                        //trains[i] += restPass;

                    }
                }
            }

            for (int i = 0; i < trains.Count; i++)
            {
                Console.Write($"{trains[i]} ");
            }

        }
    }
}
