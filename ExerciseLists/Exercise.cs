using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists
{
    public class Exercise
    {
        public void Train()
        {
            var trains = new List<int>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                trains.Add(int.Parse(item));
            }

            var maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                var passanger = Console.ReadLine();

                if (passanger == "end")
                    break;

                if (passanger.Contains("Add"))
                {
                    var addTrain = passanger.Split(" ");

                    trains.Add(int.Parse(addTrain[1]));
                }
                else
                {
                    var passangers = int.Parse(passanger);
                    int restPass = 0;

                    for (int i = 0; i < trains.Count; i++)
                    {
                        restPass = maxCapacity - (trains[i] + passangers);

                        if (restPass >= 0)
                        {
                            trains[i] += passangers;
                            restPass = 0;
                            break;
                        }

                        //trains[i] += restPass;

                    }
                }
            }

            for (int i = 0; i < trains.Count; i++)
            {
                Console.Write($"{trains[i]} ");
            }

        }
        public void ChangeList()
        {
            var changeList = new List<int>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                changeList.Add(int.Parse(item));
            }
            
            while (true)
            {
                var elem = Console.ReadLine();

                if (elem == "end")
                    break;

                if (elem.Contains("Delete"))
                {
                    var delEl = elem.Split(" ");
                    int tmpInt = int.Parse(delEl[1]);

                    for (int i = 0; i < changeList.Count; i++)
                    {
                        if (changeList[i] == tmpInt)
                        {
                            changeList.Remove(changeList[i]);
                        }
                    }
                }
                else
                {
                    var insEl = elem.Split(" ");
                    
                    changeList.Insert(int.Parse(insEl[2]), int.Parse(insEl[1]));                   
                }
            }

            for (int i = 0; i < changeList.Count; i++)
            {
                Console.Write($"{changeList[i]} ");
            }

        }       
        
        public void HouseParty()
        {
            var personList = new List<string>();
            var exeptionList = new List<string>();

            var personData = int.Parse(Console.ReadLine());

            for (int i = 0; i < personData; i++)
            {
                var personComming = Console.ReadLine();

                if (personComming.Contains("is going"))
                {
                    var personInfo = personComming.Split(" ");

                    if (personList.Contains(personInfo[0]))
                    {
                        exeptionList.Add($"{personInfo[0]} is already in the list!");
                        continue;
                    }

                    personList.Add(personInfo[0]);                
                }
                else //not going
                {
                    var personInfo = personComming.Split(" ");

                    if (!personList.Contains(personInfo[0]))
                    {
                        exeptionList.Add($"{personInfo[0]} is not in the list!");
                        continue;
                    }

                    personList.Remove(personInfo[0]);
                }
            }
            for (int i = 0; i < exeptionList.Count; i++)
            {
                Console.WriteLine($"{exeptionList[i]}");
            }

            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine($"{personList[i]}");
            }
        } 
        
        public void ListOperation()
        {
            var dataList = new List<int>();
            var exeptionList = new List<string>();

            var list = Console.ReadLine().Split(" ");

            foreach (var item in list)
            {
                dataList.Add(int.Parse(item));
            }
            
            while (true)
            {
                var elem = Console.ReadLine();

                if (elem == "End")
                    break;

                if (elem.Contains("Add"))
                {
                    var delEl = elem.Split(" ");
                    int tmpInt = int.Parse(delEl[1]);
                    dataList.Add(tmpInt);
                }
                else if (elem.Contains("Insert"))
                {
                    var insEl = elem.Split(" ");
                    
                    if (int.Parse(insEl[2]) < 0 || int.Parse(insEl[2]) > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    dataList.Insert(int.Parse(insEl[2]), int.Parse(insEl[1]));                   
                } 
                else if (elem.Contains("Remove"))
                {
                    var delEl = elem.Split(" ");
                    int tmpEl = int.Parse(delEl[1]);
                    
                     if (tmpEl < 0 || tmpEl > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }                   

                    dataList.RemoveAt(int.Parse(delEl[1]));                   
                }
                else if(elem.Contains("Shift left"))
                {                    
                    var shiftEl = elem.Split(" ");
                    int tmpLeft = int.Parse(shiftEl[2]);
                    
                    if (tmpLeft < 0 || tmpLeft > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    while(tmpLeft > 0)
                    {
                        dataList.Add(dataList[0]);
                        dataList.RemoveAt(0);

                        tmpLeft--;
                    }
                }
                else if(elem.Contains("Shift right"))
                {                    
                    var shiftEl = elem.Split(" ");
                    int tmpRight= int.Parse(shiftEl[2]);
                    
                    if (tmpRight < 0 || tmpRight > dataList.Count)
                    {
                        exeptionList.Add("Invalid index");
                        continue;
                    }

                    while(tmpRight > 0)
                    {
                        dataList.Insert(0, dataList[dataList.Count - 1]);
                        dataList.RemoveAt(dataList.Count - 1);

                        tmpRight--;
                    }
                }
            }

            for (int i = 0; i < exeptionList.Count; i++)
            {
                Console.WriteLine($"{exeptionList[i]}");
            }

            for (int i = 0; i < dataList.Count; i++)
            {
                Console.Write($"{dataList[i]} ");
            }

        }   

        public void BombNumbers()
        {
            var bombList = new List<int>();

            var bombNumbers = (Console.ReadLine().Split(" "));
            foreach (var item in bombNumbers)
            {
                bombList.Add(int.Parse(item));
            }

            var bombPower = (Console.ReadLine().Split(" "));
            var numbPower = int.Parse(bombPower[0]);
            var numbAccurancy = int.Parse(bombPower[1]);

            for (int i = 0; i < bombList.Count; i++)
            {
                int indx = bombList.IndexOf(numbPower);
                if(indx < 0 || indx > bombList.Count)
                {
                    continue;
                }

                bombList[indx] = 0;
                if(numbAccurancy > 0)
                {
                    for (int j = 1; j <= numbAccurancy; j++)
                    {
                        if(indx - j >= 0)
                        {
                            bombList[indx - j] = 0;
                        }
                        if (indx + j <= bombList.Count - 1)
                        {
                            bombList[indx + j] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(bombList.Sum());
        }

        public void CardGame()
        {
            var firstPlayer = new List<int>();
            var secondPlayer = new List<int>();


            var firstCard = (Console.ReadLine().Split(" "));
            var secondCard = (Console.ReadLine().Split(" "));

            foreach (var item in firstCard)
            {
                firstPlayer.Add(int.Parse(item));
            }

            foreach (var item in secondCard)
            {
                secondPlayer.Add(int.Parse(item));
            }

            while (true)
            {
                if(firstPlayer.Count < 1 || secondPlayer.Count < 1)
                {
                    break;
                }
                for (int i = 0; i < 
                                    (firstPlayer.Count <= secondPlayer.Count 
                                    ? firstPlayer.Count 
                                    : secondPlayer.Count);                      i++)
                {
                    if (firstPlayer[0] > secondPlayer[0])
                    {                        
                        firstPlayer.Add(firstPlayer[0]);
                        firstPlayer.Add(secondPlayer[0]);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else if(firstPlayer[i] < secondPlayer[0])
                    {
                        secondPlayer.Add(secondPlayer[0]);
                        secondPlayer.Add(firstPlayer[0]);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                }
            }

            if (firstPlayer.Count <= secondPlayer.Count)
                Console.WriteLine($"First player wins! Sum: {secondPlayer.Sum()}");
            else
                Console.WriteLine($"Second player wins! Sum: {firstPlayer.Sum()}");
        }

        public void AppendArrays()
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

        public void AnonymousTreat()
        {
            List<string> hyperVirus = new List<string>();

            List<string> virusString = Console.ReadLine().Split(" ").ToList();

            while(true)
            {
                var virusAction = Console.ReadLine().Split(" ").ToList();

                if (virusAction.Contains("3:1"))
                {
                    break;
                }

                virusString.RemoveAll(x => x.Equals(""));                

                if(virusAction.Contains("merge"))
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

                if(virusAction.Contains("divide"))
                {
                    List<string> merge = new List<string>();

                    var indx = int.Parse(virusAction[1]);
                    int parts = int.Parse(virusAction[2]);

                    if(indx > virusString.Count - 1 || indx < 0)
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
                if(virusString[i] != "" && i != virusString.Count -1)
                { 
                    virusString[i] += " ";
                }
                Console.Write($"{virusString[i]}");
            }

        }
    }
}
