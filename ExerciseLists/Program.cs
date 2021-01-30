using ExerciseLists.Tasks;
using ExerciseLists.TasksList;
using System;

namespace ExerciseLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select task of Exercise:");
            Console.WriteLine("1. Train:"); 
            Console.WriteLine("2. ChangeList:");
            Console.WriteLine("3. HouseParty:");
            Console.WriteLine("4. ListOperation:");
            Console.WriteLine("5. BombNumbers:");
            Console.WriteLine("6. CardGame:");
            Console.WriteLine("7. AppendArrays:");
            Console.WriteLine("8. AnonymousThreat:");
            Console.WriteLine("9. PokemonDontGo:");

            Train train = new Train();
            ListOperation listOperation = new ListOperation();
            HouseParty houseParty = new HouseParty();
            ChangeList changeList = new ChangeList();
            CardGame cardGame = new CardGame();
            BombNumbers bombNumbers = new BombNumbers();
            AppendArrays appendArrays = new AppendArrays();
            AnonymousTreat anonymousTreat = new AnonymousTreat();
            PokemonDontGo pokemonDontGo = new PokemonDontGo();

            int switch_on = int.Parse(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    {
                        train.TaskTrain();
                        break;
                    }
                case 2:
                    {
                        listOperation.TaskListOperation();
                        break;
                    }
                case 3:
                    {
                        houseParty.TaskHouseParty();
                        break;
                    }
                case 4:
                    {
                        cardGame.TaskCardGame();
                        break;
                    }
                case 5:
                    {
                        changeList.TaskChangeList();
                        break;
                    }
                case 6:
                    {
                        appendArrays.TaskAppendArrays();
                        break;
                    }
                case 7:
                    {
                        bombNumbers.TaskBombNumbers();
                        break;
                    }
                case 8:
                    {
                        anonymousTreat.TaskAnonymousTreat();
                        break;
                    }
                case 9:
                    {
                        pokemonDontGo.TaskPokemonDontGo();
                        break;
                    }

                default:
                    Console.WriteLine("Exit:");
                    break;
            }
        }
    }
}
