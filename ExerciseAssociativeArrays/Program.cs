using SoftUniFunds.ExerciseAssociativeArrays;
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

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
