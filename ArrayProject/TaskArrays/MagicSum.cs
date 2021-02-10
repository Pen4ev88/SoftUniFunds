using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseArray.TaskArrays
{
    public class MagicSum
    {
        public void TaskMagicSum()
        {
            int[] inputIntArr = Console
                            .ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            bool[] visitedIndex = new bool[inputIntArr.Length]
                .Select(x => x = true)
                .ToArray();

            int correctSum = int.Parse(Console.ReadLine());

            List<int[]> resArr = new List<int[]>();

            for (int i = 0; i < inputIntArr.Length; i++)
            {
                if(visitedIndex[i])
                {
                    int tmpSum = inputIntArr[i];
                    for (int j = i + 1; j < inputIntArr.Length; j++)
                    {
                        if (visitedIndex[j])
                        {
                            if (correctSum == (tmpSum + inputIntArr[j]))
                            {
                                int[] res = new int[2];
                                res[0] = inputIntArr[i];
                                res[1] = inputIntArr[j];

                                visitedIndex[j] = false;
                                
                                resArr.Add(res);
                            }
                        }
                    }                    
                }
            }

            foreach (var item in resArr)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }

        }
    }
}
