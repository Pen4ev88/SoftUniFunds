using SoftUniFunds.AssociativeArrays;
using System;
using System.Collections.Generic;

namespace SoftUniFunds
{
    public class Program
    {
        public static void Main()
        {
            Labs lab = new Labs();

            Console.WriteLine("Select task of Labs:");
            Console.WriteLine("1. CountOdd:");
            Console.WriteLine("2. OddNumber:");
            Console.WriteLine("3. Synonyms:");
            Console.WriteLine("4. Largest3:");
            Console.WriteLine("5. WordFilter:");

            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    {
                        lab.CountOdd();
                        break;
                    }
                case 2:
                    {
                        lab.OddNumber();
                        break;
                    }
                case 3:
                    {
                        lab.Synonyms();
                        break;
                    }
                case 4:
                    {
                        lab.Largest3();
                        break;
                    }
                case 5:
                    {
                        lab.WordFilter();
                        break;
                    }

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
            
        }
    }
}