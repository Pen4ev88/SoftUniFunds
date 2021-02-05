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
            string breakProgram = "course start";
            string addCommand = "Add:";
            string removeCommand = "Remove:";
            string insertCommand = "Insert:";
            string swapCommand = "Swap:";
            string exerciseCommand = "Exercise:";
            string exerciseToLesson = "Exercise";

            Dictionary<string, bool> dictLessonExercise = new Dictionary<string, bool>();

            List<string> baseScheduleList = Console.ReadLine().Split(", ").ToList();
            string tmpString = "";

            while((tmpString = Console.ReadLine()) != breakProgram )
            {   
                if(tmpString.Contains(addCommand))
                {
                    //string newCourse = tmpString.Skip(4).ToString();
                    string newCourse =  tmpString.Remove(0, 4);

                    if (!baseScheduleList.Contains(newCourse))
                    {
                        baseScheduleList.Add(newCourse);
                        dictLessonExercise.Add(newCourse, false);
                    }
                }
                else if(tmpString.Contains(removeCommand))
                {
                    //string delCourse = tmpString.Skip(7).ToString();
                    string delCourse =  tmpString.Remove(0, 7);

                    if(baseScheduleList.Contains(delCourse))
                    {
                        baseScheduleList.Remove(delCourse);
                        dictLessonExercise.Remove(delCourse);
                        if (baseScheduleList.Contains(delCourse + "-Exercise"))
                        {
                            baseScheduleList.Remove(delCourse + "-Exercise");
                        }
                    }
                }
                else if(tmpString.Contains(insertCommand))
                {
                    //string newCourse = tmpString.Skip(7).ToString();
                    string newCourse =  tmpString.Remove(0, 7);

                    string[] insString = newCourse.Split(":");
                    int position = int.Parse(insString[1]);
                    string lesson = insString[0];

                    if (!baseScheduleList.Contains(lesson))
                    {                        
                        baseScheduleList.Insert(position, lesson);
                        dictLessonExercise.Add(lesson, false);
                    }
                }
                 else if(tmpString.Contains(swapCommand))
                {
                    string newCourse= tmpString.Remove(0, 5);
                    string[] swapString = newCourse.Split(":");
                    string swapFirst = swapString[0];
                    string swapNext = swapString[1];

                    if (baseScheduleList.Contains(swapFirst) && baseScheduleList.Contains(swapNext))
                    {
                        int indxToSwapFirst = baseScheduleList.IndexOf(swapFirst);                        
                        int indxToSwapSecond = baseScheduleList.IndexOf(swapNext);

                        baseScheduleList.Insert(indxToSwapFirst, swapNext.ToString());                        
                        baseScheduleList.Insert(indxToSwapSecond + 1, swapFirst.ToString());
                        baseScheduleList.RemoveAt(indxToSwapFirst + 1);
                        baseScheduleList.RemoveAt(indxToSwapSecond + 1);

                        //baseScheduleList.Insert(indxToSwapFirst, swapNext.ToString());

                        //if (baseScheduleList.Contains(swapNext + "-Exercise"))
                        //{
                        //    int indxExercise = baseScheduleList.IndexOf(swapNext + "-Exercise");
                        //    baseScheduleList.Insert(indxToSwapFirst + 1, (swapNext + "-Exercise").ToString());
                        //    baseScheduleList.RemoveAt(indxExercise + 1);
                        //    baseScheduleList.RemoveAt(indxToSwapFirst + 2);
                        //    indxToSwapSecond++;
                        //}
                        //else
                        //{
                        //    baseScheduleList.RemoveAt(indxToSwapFirst + 1);
                        //}

                        //baseScheduleList.Insert(indxToSwapSecond, swapFirst.ToString());

                        //if (baseScheduleList.Contains(swapFirst + "-Exercise"))
                        //{
                        //    int indxExercise = baseScheduleList.IndexOf(swapFirst + "-Exercise");
                        //    baseScheduleList.Insert(indxToSwapSecond + 1, (swapFirst + "-Exercise").ToString());
                        //    baseScheduleList.RemoveAt(indxExercise + 1);
                        //    baseScheduleList.RemoveAt(indxToSwapSecond + 2);
                        //}
                        //else
                        //{
                        //    baseScheduleList.RemoveAt(indxToSwapSecond + 1);
                        //}
                    }
                }          
                 else if(tmpString.Contains(exerciseCommand))
                { 
                    //string lessonExercise = tmpString.Skip(9).ToString();
                    string lessonExercise = tmpString.Remove(0, 9);

                    if (!baseScheduleList.Contains(lessonExercise))
                    {                        
                        baseScheduleList.Add(lessonExercise);
                        dictLessonExercise.Add(lessonExercise, true);
                        //baseScheduleList.Add(lessonExercise + "-Exercise");                        
                    }
                    else
                    {
                        //int indx = baseScheduleList.IndexOf(lessonExercise);
                        dictLessonExercise[lessonExercise] = true;
                        //baseScheduleList.Insert(indx , lessonExercise + "-Exercise");
                    }
                }                      
            }

            int outputCount = 1;

            for (int i = 0; i < baseScheduleList.Count; i++)
            {
                Console.WriteLine($"{outputCount}.{baseScheduleList[i]}");
                if(dictLessonExercise.ContainsKey(baseScheduleList[i]))
                {
                    if(dictLessonExercise[baseScheduleList[i]])
                    {
                        Console.WriteLine($"{outputCount + 1}.{baseScheduleList[i]}-{exerciseToLesson}");
                    }
                }
                outputCount++;
            }
        }
    }
}
