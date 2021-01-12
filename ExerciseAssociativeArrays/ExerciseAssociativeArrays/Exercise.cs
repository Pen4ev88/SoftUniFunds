using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace SoftUniFunds.ExerciseAssociativeArrays
{
    public class Exercise
    {
        public void CountChar()
        {
            var chars = Console.ReadLine().ToList();

            var dictChars = new Dictionary<char, int>();

            foreach (var ch in chars)
            {
                if (!dictChars.ContainsKey(ch))
                {
                    dictChars[ch] = 0;
                }

                dictChars[ch]++;
            }

            foreach (var kvp in dictChars)
            {
                if (kvp.Key != ' ')
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }

        public void MinerTast()
        {
            var resourceDict = new Dictionary<string, int>();
            string resource = "";
            int quantity = 0;
            do
            {
                resource = "";
                quantity = 0;
                resource = Console.ReadLine();
                if (resource == "stop")
                    break;

                quantity = int.Parse(Console.ReadLine());

                if (!resourceDict.ContainsKey(resource))
                {
                    resourceDict[resource] = 0;
                }
                resourceDict[resource] += quantity;
            }
            while (true);   

            foreach (var kvp in resourceDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        public void LegendaryFarming()
        {
            var farmDict = new Dictionary<string, int>();
            var farmDictJunk = new Dictionary<string, int>();

            var material = "";
            int quantity = 0;

            bool flagWin = false;

            while(!flagWin) 
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

            if(farmDict.Count() < 3)
            {
                if (!farmDict.ContainsKey("fragments"))
                {
                    farmDict["fragments"] = 0;
                }                if (!farmDict.ContainsKey("motes"))
                {
                    farmDict["motes"] = 0;
                }                if (!farmDict.ContainsKey("shards"))
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

        public void Orders()
        {
            var productDict = new Dictionary<string, List<double>>();
            string[] product = new string[3];

            double quantity = 0;
            double price;

            do
            {
                price = 0;
                quantity = 0;
                product = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (product[0] == "buy")
                    break;

                price = double.Parse(product[1], CultureInfo.InvariantCulture);
                quantity = double.Parse(product[2], CultureInfo.InvariantCulture);

                if (!productDict.ContainsKey(product[0]))
                {
                    productDict[product[0]] = new List<double>();
                    productDict[product[0]].Add(price);
                    productDict[product[0]].Add(quantity);
                }
                else
                {
                    productDict[product[0]].Remove(productDict[product[0]].First());
                    productDict[product[0]].Add(price);
                    quantity += productDict[product[0]].First();                    
                    productDict[product[0]].Remove(productDict[product[0]].First());
                    productDict[product[0]].Add(quantity);
                }

            }
            while (true);

            foreach (var kvp in productDict)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value.FirstOrDefault() * kvp.Value.LastOrDefault()):F2}");
            }
        }

    }
}
