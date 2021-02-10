using System;

namespace ExerciseArray.TaskArrays
{
    public class TopIntegers
    {
        public void TaskTopIntegers()
        {
            var inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArr.Length; i++)
            {
                bool flagMax = true;
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if(int.Parse(inputArr[i]) < int.Parse(inputArr[j]))
                    {
                        flagMax = false;
                    }
                }

                if(flagMax)
                {
                    Console.Write($"{int.Parse(inputArr[i])} ");
                }
            }  
        }
    }
}
