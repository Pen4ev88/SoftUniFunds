using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class Orders
    {
        public void TaskOrders()
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
