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
            Console.WriteLine("5.TopIntegers:");
            Console.WriteLine("6.EqualSum:");
            Console.WriteLine("7.MaxSequenceEquals:");
            Console.WriteLine("8.MagicSum:");

            Train train = new Train();
            CommonElements commonElements = new CommonElements();
            ZigZag zigZag = new ZigZag();
            ArrayRotation arrayRotation = new ArrayRotation();
            TopIntegers topIntegers = new TopIntegers();
            EqualSum equalSum = new EqualSum();
            MaxSequenceEquals maxSequenceEquals = new MaxSequenceEquals();
            MagicSum magicSum = new MagicSum();
            
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
               case 5:
                    topIntegers.TaskTopIntegers();
                    break;
               case 6:
                    equalSum.TaskEqualSum();
                    break;
               case 7:
                    maxSequenceEquals.TaskMaxSequenceEquals();
                    break;
               case 8:
                    magicSum.TaskMagicSum();
                    break;

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
