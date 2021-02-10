using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseArray.TaskArrays
{
    public class MaxSequenceEquals
    {
        public void TaskMaxSequenceEquals()
        {
            int maxSequenceCount = 0;
            int maxSequenceNumb = 0;

            int[] inputIntArr = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();           

            bool[] flagEqual = new bool[inputIntArr.Length];

            for (int i = 0; i < inputIntArr.Length; i++)
            {
                int tmpSequence = 1;
                for (int j = i + 1; j < inputIntArr.Length; j++)
                {                    
                    if (inputIntArr[i] == inputIntArr[j])
                    {
                        tmpSequence++;

                        if(tmpSequence > maxSequenceCount)
                        {
                            maxSequenceNumb = inputIntArr[i];
                            maxSequenceCount = tmpSequence;                            
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < maxSequenceCount; i++)
            {
                Console.Write(maxSequenceNumb + " ");
            }   
        }
    }
}
