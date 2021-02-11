using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseArray.TaskArrays
{
    public class KaminoFactory
    {
        public void TaskKaminoFactory()
        {
            int lenghtOgDNA = int.Parse(Console.ReadLine());

            string endProgram = "Clone them!";

            List<string[]> DNAInput = new List<string[]>();
            List<int> DNAIntSum = new List<int>();

            List<int> maxSequence = new List<int>();

            List<int> startIndexSequence = new List<int>();

            string inputDNA = "";
            while (endProgram != (inputDNA = Console.ReadLine()))
            {
                string[] inputDNAArr = inputDNA
                .Split("!", StringSplitOptions.RemoveEmptyEntries);

                int tmpSum = inputDNAArr
                    .Select(int.Parse)
                    .Sum();

                DNAIntSum.Add(tmpSum);

                DNAInput.Add(inputDNAArr);

                int maxOnesSequence = -1;
                int startIndex = -1;

                for (int i = 0; i < inputDNAArr.Length - 1; i++)
                {     
                    int j = i + 1;
                    int onesSequence = 1; 
                    
                    while (i < inputDNAArr.Length - 1)
                    {
                        if (inputDNAArr[i] == inputDNAArr[j] && inputDNAArr[i] == "1")
                        {
                            onesSequence++;
                            if (maxOnesSequence < onesSequence)
                            {
                                startIndex = i;
                                maxOnesSequence = onesSequence;
                            }

                            i++;
                            j++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if(maxOnesSequence > 1)
                {
                    startIndex = startIndex - maxOnesSequence + 2; // calculate first index of sequence
                    //maxOnesSequence++;  // adding 1 because maxOnesSequance starts with 0
                }
                maxSequence.Add(maxOnesSequence); //list of max sequence of every inputLine
                startIndexSequence.Add(startIndex); //list of indexs of every inputLine
            }

            int resIndex = ResultData(maxSequence, startIndexSequence, DNAIntSum);

            foreach (var dna in DNAInput[resIndex])
            {
                Console.Write(dna + " ");
            }
        }

        public int ResultData(List<int>  maxSequence, List<int> indexSequence, List<int> DNASum)
        {
            int maxInt = maxSequence.Max();
            int minIndx = maxSequence.Count - 1;
            int maxSum = 0;

            for (int i = 0; i < maxSequence.Count; i++)
            {
                if (maxSequence[i] == maxInt)
                {
                    if(indexSequence[i] <= minIndx)
                    {
                        if (indexSequence[i] == minIndx)
                        {
                            if (maxSum < DNASum[i])
                            {
                                maxSum = DNASum[i];
                                minIndx = indexSequence[i];
                            }
                        }
                        else
                        {
                            maxSum = DNASum[i];
                            minIndx = indexSequence[i];
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {minIndx + 1} with sum: {maxSum}");

            return minIndx;
        }
    }
}
