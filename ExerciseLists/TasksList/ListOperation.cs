using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.Tasks
{
    public class ListOperation
    {
        public void TaskListOperation()
        {
            var dataList = new List<int>();
            var exeptionList = new List<string>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                dataList.Add(int.Parse(item));
            }

            while (true)
            {
                var elem = Console.ReadLine();

                if (elem == "End")
                    break;

                if (elem.Contains("Add"))
                {
                    var delEl = elem.Split(" ");
                    int tmpInt = int.Parse(delEl[1]);
                    dataList.Add(tmpInt);
                }
                else if (elem.Contains("Insert"))
                {
                    var insEl = elem.Split(" ");

                    if (int.Parse(insEl[2]) < 0 || int.Parse(insEl[2]) > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    dataList.Insert(int.Parse(insEl[2]), int.Parse(insEl[1]));
                }
                else if (elem.Contains("Remove"))
                {
                    var delEl = elem.Split(" ");
                    int tmpEl = int.Parse(delEl[1]);

                    if (tmpEl < 0 || tmpEl > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    dataList.RemoveAt(int.Parse(delEl[1]));
                }
                else if (elem.Contains("Shift left"))
                {
                    var shiftEl = elem.Split(" ");
                    int tmpLeft = int.Parse(shiftEl[2]);

                    if (tmpLeft < 0 || tmpLeft > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    while (tmpLeft > 0)
                    {
                        dataList.Add(dataList[0]);
                        dataList.RemoveAt(0);

                        tmpLeft--;
                    }
                }
                else if (elem.Contains("Shift right"))
                {
                    var shiftEl = elem.Split(" ");
                    int tmpRight = int.Parse(shiftEl[2]);

                    if (tmpRight < 0 || tmpRight > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    while (tmpRight > 0)
                    {
                        dataList.Insert(0, dataList[dataList.Count - 1]);
                        dataList.RemoveAt(dataList.Count - 1);

                        tmpRight--;
                    }
                }
            }

            for (int i = 0; i < exeptionList.Count; i++)
            {
                Console.WriteLine($"{exeptionList[i]}");
            }

            for (int i = 0; i < dataList.Count; i++)
            {
                Console.Write($"{dataList[i]} ");
            }

        }
    }
}
