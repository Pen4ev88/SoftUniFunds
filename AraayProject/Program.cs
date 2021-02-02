using System;
using ExerciseArray;
using ExerciseArray.TaskArrays;

namespace ExerciseArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select task of Exercise:");
            Console.WriteLine("1.Train:");

            Train train = new Train();

            
            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1: train.TaskTrain();
                    break;


                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
