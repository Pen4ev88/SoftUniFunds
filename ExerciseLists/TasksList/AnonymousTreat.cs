using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class AnonymousTreat
    {
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

                    for (int i = 0; i < virusString.Count; i++)
                    {
                        if ((i < startIndx || i > endIndx) && virusString[i] != "")
                        {
                            continue;
                        }
                        else
                        {
                            int whileTrue = endIndx - startIndx + 1;
                            string strArray = "";
                            int nextIndx = startIndx;
                            while (whileTrue > 0)
                            {
                                strArray += virusString[nextIndx];
                                nextIndx++;
                                whileTrue--;
                            }

                            i = endIndx;

                            merge.Add(strArray);
                        }
                    }

                    virusString.RemoveAt(endIndx);
                    virusString.InsertRange(endIndx, merge);


                    for (int i = startIndx; i < endIndx; i++)
                    {
                        virusString[i] = "";
                    }
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
