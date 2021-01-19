using System;
using System.Collections.Generic;
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
    }
}
