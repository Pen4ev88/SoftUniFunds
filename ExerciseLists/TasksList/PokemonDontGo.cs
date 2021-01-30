using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseLists.TasksList
{
    public class PokemonDontGo
    {
        public void TaskPokemonDontGo()
        {
            List<int> listPokemons = new List<int>();
            string[] listInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sumScore = 0;

            foreach (var pokemon in listInput)
            {
                listPokemons.Add(int.Parse(pokemon));
            }

            while(listPokemons.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());

                bool flagDelete = false;
                if(indexToRemove < 0)
                {
                    listPokemons.RemoveAt(0);
                    listPokemons.Insert(0, listPokemons[listPokemons.Count - 1]);
                    indexToRemove = 1;
                    flagDelete = true;
                }
                if (indexToRemove > listPokemons.Count - 1)
                {
                    listPokemons.RemoveAt(listPokemons.Count - 1);
                    listPokemons.Add(listPokemons[0]);
                    indexToRemove = listPokemons.Count - 1;
                    flagDelete = true;
                }

                for (int i = 0; i < listPokemons.Count; i++)
                {
                    if (i == indexToRemove)
                    {
                        sumScore += listPokemons[indexToRemove];

                    }
                    else
                    {
                        if(listPokemons[i] <= listPokemons[indexToRemove])
                        {
                            listPokemons[i] += listPokemons[indexToRemove];
                        }
                        else
                        {
                            listPokemons[i] -= listPokemons[indexToRemove];
                        }
                    }
                }
                if (!flagDelete)
                {
                    listPokemons.RemoveAt(indexToRemove);
                }

            }

            Console.WriteLine(sumScore);

        }
    }
}
