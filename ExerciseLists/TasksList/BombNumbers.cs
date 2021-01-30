using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class BombNumbers
    {
        public void TaskBombNumbers()
        {
            var bombList = new List<int>();

            var bombNumbers = (Console.ReadLine().Split(" "));
            foreach (var item in bombNumbers)
            {
                bombList.Add(int.Parse(item));
            }

            var bombPower = (Console.ReadLine().Split(" "));
            var numbPower = int.Parse(bombPower[0]);
            var numbAccurancy = int.Parse(bombPower[1]);

            for (int i = 0; i < bombList.Count; i++)
            {
                int indx = bombList.IndexOf(numbPower);
                if (indx < 0 || indx > bombList.Count)
                {
                    continue;
                }

                bombList[indx] = 0;
                if (numbAccurancy > 0)
                {
                    for (int j = 1; j <= numbAccurancy; j++)
                    {
                        if (indx - j >= 0)
                        {
                            bombList[indx - j] = 0;
                        }
                        if (indx + j <= bombList.Count - 1)
                        {
                            bombList[indx + j] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(bombList.Sum());
        }
    }
}
