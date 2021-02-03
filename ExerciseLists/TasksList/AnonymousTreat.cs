using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class AnonymousTreat
    {
        // TODO - Rename
        public string JoinMyStrings(string x, string y) => string.Join("", new string[] { x, y });

        public void TaskAnonymousTreat()
        {
            List<string> hyperVirus = new List<string>();

            List<string> virusString = Console.ReadLine().Split(" ").ToList();

            while (true)
            {
                var virusAction = Console.ReadLine().Split(" ").ToList();

                if (virusAction.Contains("3:1"))
                {
                    break;
                }

                virusString.RemoveAll(x => x.Equals(""));

                if (virusAction.Contains("merge"))
                {
                    List<string> merge = new List<string>();

                    // TODO - Math.Min/Max

                    int startIndx = int.Parse(virusAction[1]);
                    int endIndx = int.Parse(virusAction[2]);
                    
                    if (startIndx < 0)
                    {
                        startIndx = 0;
                    }
                    if (endIndx > virusString.Count - 1)
                    {
                        endIndx = virusString.Count - 1;
                    }

                    // Skip items before start index and save them
                    IEnumerable<string> skippedElements = virusString
                        .Take(startIndx);                        

                    // Merge items between start ind and end ind
                    string mergedItemsResult  = virusString
                        .Skip(startIndx)
                        .Take(endIndx - startIndx) 
                        .Aggregate(JoinMyStrings);

                    // Collect left items after merge
                    IEnumerable<string> leftItemsAfterMerge = virusString
                        .TakeLast(virusString.Count - endIndx); 

                    virusString = new List<string>(skippedElements);
                    virusString.Add(mergedItemsResult);
                    virusString.AddRange(leftItemsAfterMerge);
                }

                if (virusAction.Contains("divide"))
                {
                    List<string> merge = new List<string>();

                    var indx = int.Parse(virusAction[1]);
                    int parts = int.Parse(virusAction[2]);

                    if (indx > virusString.Count - 1 || indx < 0)
                    {
                        continue;
                    }

                    for (int i = 0; i < virusString.Count; i++)
                    {
                        if (i != indx)
                        {
                            //merge.Add(virusString[i]);
                            continue;
                        }
                        else
                        {
                            string strDiv = virusString[indx];
                            int lenStr = strDiv.Length;
                            int partsDiv = lenStr / parts;

                            int whileTrue = parts;

                            string strArray = "";
                            strArray += virusString[indx];
                            while (whileTrue > 0)
                            {
                                string str = "";
                                if (whileTrue != 1)
                                {
                                    str = new string(strArray.Take(partsDiv).ToArray());
                                }
                                else
                                {
                                    str = new string(strArray.Take(strArray.Length).ToArray());
                                }
                                strArray = strArray.Remove(0, partsDiv);
                                merge.Add(str);
                                whileTrue--;
                            }
                            virusString.RemoveAt(indx);
                            virusString.AddRange(merge);
                        }
                    }

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
