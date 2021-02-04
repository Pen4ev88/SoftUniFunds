using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class AnonymousThreat
    {
        public void TaskAnonymousThreat()
        {
            string breakProgram = "3:1";
            string mergeCommand = "merge";
            string divideCommand = "divide";

            List<string> virusString = Console.ReadLine().Split(" ").ToList();

            string virusAction = "";

            while ((virusAction = Console.ReadLine()) != breakProgram)
            {
                var commandArr = virusAction.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commandArr[0];

                if (command.Contains(mergeCommand))
                {
                    List<string> merge = new List<string>();

                    int startIndx = int.Parse(commandArr[1]);
                    int endIndx = int.Parse(commandArr[2]);
                    int rangeIndex = endIndx - startIndx;

                    startIndx = Math.Max(0, startIndx);
                    endIndx = Math.Min(endIndx, virusString.Count - 1);
                    if (startIndx > endIndx)
                    {
                        startIndx = Math.Max(0, endIndx - rangeIndex);
                    }

                    IEnumerable<string> beforeMerge = virusString
                        .Take(startIndx);

                    string mergeString = virusString
                        .Skip(startIndx)
                        .Take(endIndx - startIndx + 1)
                        .Aggregate((x, y) => string.Join("", new string[] { x, y}));

                    IEnumerable<string> leftItems = virusString
                        .TakeLast((virusString.Count - 1) - endIndx);

                    virusString = new List<string>(beforeMerge);
                    virusString.Add(mergeString);
                    virusString.AddRange(leftItems);
                }

                if (command.Contains(divideCommand))
                {   
                    int startIndx = int.Parse(commandArr[1]);
                    int endIndx = int.Parse(commandArr[2]);

                    int indx = Math.Max(0, virusString.Count - 1);

                    int parts = int.Parse(commandArr[2]);

                    IEnumerable<string> beforeDivide = virusString
                        .Take(indx);

                    IEnumerable<string> divided = virusString
                        .Skip(indx)
                        .Take(1);

                    IEnumerable<string> leftItems = virusString
                        .TakeLast((virusString.Count - 1) - indx);

                    string div = divided.First();

                    virusString = new List<string>(beforeDivide);

                    int lenStr = div.Length;
                    int partsDiv = lenStr / parts;
                    
                    int step = 0;
                    var subPartString = "";
                    while (parts > 0)
                    {
                        subPartString = div.Substring(step, partsDiv);

                        virusString.Add(subPartString);
                        step += partsDiv;
                        parts--;
                    }

                    virusString.AddRange(leftItems);
                }
            }

            for (int i = 0; i < virusString.Count; i++)
            {
                if (virusString[i] != "" && i != virusString.Count - 1)
                {
                    virusString[i] += " ";
                }
                Console.Write($"{virusString[i]}");
            }
        }

    }
}
