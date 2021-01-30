using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseLists.TasksList
{
    public class CardGame
    {
        public void TaskCardGame()
        {
            var firstPlayer = new List<int>();
            var secondPlayer = new List<int>();


            var firstCard = (Console.ReadLine().Split(" "));
            var secondCard = (Console.ReadLine().Split(" "));

            foreach (var item in firstCard)
            {
                firstPlayer.Add(int.Parse(item));
            }

            foreach (var item in secondCard)
            {
                secondPlayer.Add(int.Parse(item));
            }

            while (true)
            {
                if (firstPlayer.Count < 1 || secondPlayer.Count < 1)
                {
                    break;
                }
                for (int i = 0; i <
                                    (firstPlayer.Count <= secondPlayer.Count
                                    ? firstPlayer.Count
                                    : secondPlayer.Count); i++)
                {
                    if (firstPlayer[0] > secondPlayer[0])
                    {
                        firstPlayer.Add(firstPlayer[0]);
                        firstPlayer.Add(secondPlayer[0]);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else if (firstPlayer[i] < secondPlayer[0])
                    {
                        secondPlayer.Add(secondPlayer[0]);
                        secondPlayer.Add(firstPlayer[0]);
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        firstPlayer.RemoveAt(0);
                        secondPlayer.RemoveAt(0);
                        break;
                    }
                }
            }

            if (firstPlayer.Count <= secondPlayer.Count)
                Console.WriteLine($"First player wins! Sum: {secondPlayer.Sum()}");
            else
                Console.WriteLine($"Second player wins! Sum: {firstPlayer.Sum()}");
        }
    }
}
