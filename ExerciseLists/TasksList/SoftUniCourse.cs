using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class SoftUniCourse
    {
        public void TaskSoftUniCourse()
        {
            List<string> baseSchedule = Console.ReadLine().Split(", ").ToList();
            string tmpString = "";

            while(true)
            {   
                tmpString = Console.ReadLine();

                if(tmpString == "course start")
                {
                    break;
                }                

                if(tmpString.Contains("Add:"))
                {
                    string newCourse= tmpString.Remove(0, 4);

                    if (!baseSchedule.Contains(newCourse))
                    {
                        baseSchedule.Add(newCourse);
                    }
                }
                else if(tmpString.Contains("Remove:"))
                {
                    string newCourse= tmpString.Remove(0, 7);

                    if(baseSchedule.Contains(newCourse))
                    {
                        baseSchedule.Remove(newCourse);
                        if(baseSchedule.Contains(newCourse +"-Exercise"))
                        {
                            baseSchedule.Remove(newCourse +"-Exercise");
                        }
                    }
                }
                else if(tmpString.Contains("Insert:"))
                {
                    string newCourse= tmpString.Remove(0, 7);
                    string[] insString = newCourse.Split(":");

                    if (!baseSchedule.Contains(insString[0]))
                    {
                        int position = int.Parse(insString[1].ToString());
                        baseSchedule.Insert(position, insString[0].ToString());
                    }
                }
                 else if(tmpString.Contains("Swap:"))
                {
                    string newCourse= tmpString.Remove(0, 5);
                    string[] swapString = newCourse.Split(":");

                    if (baseSchedule.Contains(swapString[0]) && baseSchedule.Contains(swapString[1]))
                    {
                        int indxToSwapFirst = baseSchedule.IndexOf(swapString[0]);                        
                        int indxToSwapSecond = baseSchedule.IndexOf(swapString[1]);

                        baseSchedule.Insert(indxToSwapFirst, swapString[1].ToString());

                        if (baseSchedule.Contains(swapString[1] + "-Exercise"))
                        {
                            int indxExercise = baseSchedule.IndexOf(swapString[1] + "-Exercise");
                            baseSchedule.Insert(indxToSwapFirst + 1, (swapString[1] + "-Exercise").ToString());
                            baseSchedule.RemoveAt(indxExercise + 1);
                            baseSchedule.RemoveAt(indxToSwapFirst + 2);
                            indxToSwapSecond++;
                        }
                        else
                        {
                            baseSchedule.RemoveAt(indxToSwapFirst + 1);
                        }

                        baseSchedule.Insert(indxToSwapSecond, swapString[0].ToString());

                        if (baseSchedule.Contains(swapString[0] + "-Exercise"))
                        {
                            int indxExercise = baseSchedule.IndexOf(swapString[0] + "-Exercise");
                            baseSchedule.Insert(indxToSwapSecond + 1, (swapString[0] + "-Exercise").ToString());
                            baseSchedule.RemoveAt(indxExercise + 1);
                            baseSchedule.RemoveAt(indxToSwapSecond + 2);
                        }
                        else
                        {
                            baseSchedule.RemoveAt(indxToSwapSecond + 1);
                        }
                    }
                }          
                 else if(tmpString.Contains("Exercise:"))
                { 
                    string lessonExercise = tmpString.Remove(0, 9);

                    if (!baseSchedule.Contains(lessonExercise))
                    {
                        baseSchedule.Add(lessonExercise);
                        baseSchedule.Add(lessonExercise + "-Exercise");                        
                    }
                    else
                    {
                        int indx = baseSchedule.IndexOf(lessonExercise);
                        baseSchedule.Insert(indx , lessonExercise + "-Exercise");
                    }
                }                      
            }

            for (int i = 0; i < baseSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{baseSchedule[i]}");
            }
        }
    }
}
