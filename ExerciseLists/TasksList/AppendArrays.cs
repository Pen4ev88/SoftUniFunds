using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    class AppendArrays
    {
        public void TaskAppendArrays()
        {
            var orderList = new List<int>();

            var allLists = Console.ReadLine().Split("|");

            for (int i = allLists.Length - 1; i >= 0; i--)

            {
                var subList = allLists[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var tmpList = new List<int>();
                for (int j = 0; j < subList.Length; j++)
                {
                    tmpList.Add(int.Parse(subList[j]));
                }

                orderList.AddRange(tmpList);
            }

            foreach (var item in orderList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
