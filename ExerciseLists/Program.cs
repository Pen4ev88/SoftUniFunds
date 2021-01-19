using System;

namespace ExerciseLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            Console.WriteLine("Select task of Exercise:");
            Console.WriteLine("1. CountChar:"); 
            Console.WriteLine("2. ChangeList:");
            Console.WriteLine("3. HouseParty:");
            Console.WriteLine("4. ListOperation:");

            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    {
                        exercise.Train();
                        break;
                    }
                case 2:
                    {
                        exercise.ChangeList();
                        break;
                    }
                case 3:
                    {
                        exercise.HouseParty();
                        break;
                    }
                case 4:
                    {
                        exercise.ListOperation();
                        break;
                    }

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
