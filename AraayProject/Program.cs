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
            Console.WriteLine("2.CommonElements:");
            Console.WriteLine("3.ZigZag:");
            Console.WriteLine("4.ArrayRotation:");

            Train train = new Train();
            CommonElements commonElements = new CommonElements();
            ZigZag zigZag = new ZigZag();
            ArrayRotation arrayRotation = new ArrayRotation();

            
            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1: train.TaskTrain();
                    break;
                case 2: commonElements.TaskCommonElements();
                    break;
                case 3: zigZag.TaskZigZag();
                    break;
                case 4:
                    arrayRotation.TaskArrayRotation();
                    break;

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
