using System;
using System.Linq;

namespace ExerciseArray.TaskArrays
{
    public class CommonElements
    {
        public void TaskCommonElements()
        {
            string[] baseArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < secondArray.Length; i++)
            {
                if(baseArray.Contains(secondArray[i]))
                {
                    Console.Write(secondArray[i] + " ");
                }
            } 

        }
    }
}
