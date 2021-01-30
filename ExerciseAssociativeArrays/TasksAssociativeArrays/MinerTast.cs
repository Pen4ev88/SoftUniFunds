using System;
using System.Collections.Generic;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class MinerTast
    {
        public void TaskMinerTast()
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
    }
}
