using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.Tasks
{
    public class ChangeList
    {
        public void TaskChangeList()
        {
            var changeList = new List<int>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                changeList.Add(int.Parse(item));
            }

            while (true)
            {
                var elem = Console.ReadLine();

                if (elem == "end")
                    break;

                if (elem.Contains("Delete"))
                {
                    var delEl = elem.Split(" ");
                    int tmpInt = int.Parse(delEl[1]);

                    for (int i = 0; i < changeList.Count; i++)
                    {
                        if (changeList[i] == tmpInt)
                        {
                            changeList.Remove(changeList[i]);
                        }
                    }
                }
                else
                {
                    var insEl = elem.Split(" ");

                    changeList.Insert(int.Parse(insEl[2]), int.Parse(insEl[1]));
                }
            }

            for (int i = 0; i < changeList.Count; i++)
            {
                Console.Write($"{changeList[i]} ");
            }

        }
    }
}
