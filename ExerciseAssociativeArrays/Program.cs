﻿using SoftUniFunds.ExerciseAssociativeArrays;
using System;

namespace ExerciseAssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            Console.WriteLine("Select task of Exercise:");
            Console.WriteLine("1. CountChar:");
            Console.WriteLine("2. MinerTest:");
            Console.WriteLine("3. LegendaryFarming:");
            Console.WriteLine("4. Orders:");
            Console.WriteLine("5. SoftUniParking:");
            Console.WriteLine("6. Cources:");
            Console.WriteLine("7. StudentAcademy:");
            Console.WriteLine("8. CompanyUser:");
            Console.WriteLine("9. ForceBook:");
            Console.WriteLine("10. Exam:");

            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    {
                        exercise.CountChar();
                        break;
                    }
                case 2:
                    {
                        exercise.MinerTast();
                        break;
                    }
                 case 3:
                    {
                        exercise.LegendaryFarming();
                        break;
                    } 
                 case 4:
                    {
                        exercise.Orders();
                        break;
                    } 
                 case 5:
                    {
                        exercise.SoftUniParking();
                        break;
                    } 
                 case 6:
                    {
                        exercise.Courses();
                        break;
                    } 
                 case 7:
                    {
                        exercise.StudentAcademy();
                        break;
                    } 
                 case 8:
                    {
                        exercise.CompanyUser();
                        break;
                    } 
                 case 9:
                    {
                        exercise.ForceBook();
                        break;
                    }
                  case 10:
                    {
                        exercise.SoftUniExam();
                        break;
                    }             
                
                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
