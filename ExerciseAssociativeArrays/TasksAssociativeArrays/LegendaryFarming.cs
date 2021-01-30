using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class LegendaryFarming
    {
        public void TsakLegendaryFarming()
        {
            var farmDict = new Dictionary<string, int>();
            var farmDictJunk = new Dictionary<string, int>();

            var material = "";
            int quantity = 0;

            bool flagWin = false;

            while (!flagWin)
            {
                var array = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < array.Length; i += 2)
                {
                    quantity = int.Parse(array[i]);
                    material = array[i + 1].ToLower();

                    if (material == "fragments" || material == "motes" || material == "shards")
                    {
                        if (!farmDict.ContainsKey(material))
                        {
                            farmDict[material] = quantity;
                        }
                        else
                        {
                            farmDict[material] += quantity;
                        }
                    }
                    else
                    {
                        if (!farmDictJunk.ContainsKey(material))
                        {
                            farmDictJunk[material] = quantity;
                        }
                        else
                        {
                            farmDictJunk[material] += quantity;
                        }
                    }

                    if (material == "fragments" && farmDict[material] - 250 >= 0)
                    {
                        farmDict[material] -= 250;
                        Console.WriteLine("Valanyr obtained!");
                        flagWin = true;
                        break;
                    }
                    if (material == "motes" && farmDict[material] - 250 >= 0)
                    {
                        farmDict[material] -= 250;
                        Console.WriteLine("Dragonwrath obtained!");
                        flagWin = true;
                        break;
                    }
                    if (material == "shards" && farmDict[material] - 250 >= 0)
                    {
                        farmDict[material] -= 250;
                        Console.WriteLine("Shadowmourne obtained!");
                        flagWin = true;
                        break;
                    }

                }
            }

            if (farmDict.Count() < 3)
            {
                if (!farmDict.ContainsKey("fragments"))
                {
                    farmDict["fragments"] = 0;
                }
                if (!farmDict.ContainsKey("motes"))
                {
                    farmDict["motes"] = 0;
                }
                if (!farmDict.ContainsKey("shards"))
                {
                    farmDict["shards"] = 0;
                }
            }

            var firstfarm = farmDict.Select(kvp => kvp)
                                  .OrderByDescending(kvp => kvp.Value)
                                  .ThenBy(kvp => kvp.Key)
                                  .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            var secondFarm = farmDictJunk.Select(kvp => kvp)
                                 .OrderBy(kvp => kvp.Key)
                                 .ThenBy(kvp => kvp.Value)
                                 .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in firstfarm)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in secondFarm)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
