using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseArray.TaskArrays
{
    public class EqualSum
    {
        public void TaskEqualSum()
        {
            string constNoIndex = "no";
            List<int> equalList = new List<int>();
            int equalIndex = -1;

            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);            

            for (int i = 0; i < inputArr.Length; i++)
            {
                equalList.Add(int.Parse(inputArr[i]));
            }    

            if (inputArr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < equalList.Count - 1; i++)
            {
                int firstSum = equalList
                    .Take(i)                    
                    .Sum();

                int lastSum = equalList
                    .TakeLast((equalList.Count - 1) - (i))
                    .Sum();

                if (firstSum == lastSum)
                {
                    equalIndex = i;
                    break;
                }
            }

            if(equalIndex != -1)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine(constNoIndex);
            }
        }
    }
}
