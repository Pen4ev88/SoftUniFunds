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
            Console.WriteLine("5. BombNumbers:");
            Console.WriteLine("6. CardGame:");
            Console.WriteLine("7. AppendArrays:");
            Console.WriteLine("8. AnonymousThreat:");

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
                case 5:
                    {
                        exercise.BombNumbers();
                        break;
                    }
                case 6:
                    {
                        exercise.CardGame();
                        break;
                    }
                case 7:
                    {
                        exercise.AppendArrays();
                        break;
                    }
                case 8:
                    {
                        exercise.AnonymousTreat();
                        break;
                    }


                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
