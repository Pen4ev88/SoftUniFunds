using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class SoftUniParking
    {
        public void TaskSoftUniParking()
        {
            var number = int.Parse(Console.ReadLine());
            var stringBuilder = new StringBuilder();

            var parkAccount = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] user = Console.ReadLine()
                     .Split()
                     .ToArray();

                if (user.Count() == 3) //register
                {
                    string userId = user[1];

                    if (!parkAccount.ContainsKey(userId))
                    {
                        parkAccount[userId] = user[2];
                        stringBuilder.Append($"{userId} registered {user[2]} successfully\n");
                    }
                    else
                    {
                        stringBuilder.Append($"ERROR: already registered with plate number {user[2]}\n");
                    }
                }
                else //unregister
                {
                    if (!parkAccount.ContainsKey(user[1]))
                    {
                        stringBuilder.Append($"ERROR: user {user[1]} not found\n");
                    }
                    else
                    {
                        stringBuilder.Append($"{user[1]} unregistered successfully\n");
                        parkAccount.Remove(user[1]);
                    }
                }
            }

            foreach (var user in parkAccount)
            {
                stringBuilder.Append($"{user.Key} => {user.Value}\n");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
