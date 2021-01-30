using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace ExerciseAssociativeArrays.TasksAssociativeArrays
{
    public class ForceBook
    {
        public void TaskForceBook()
        {
            SortedDictionary<string, string> sideNameUsers = new SortedDictionary<string, string>();
            Dictionary<string, string> sideTranslate = new Dictionary<string, string>();
            List<string> joinUser = new List<string>();

            while (true)
            {
                var userForce = Console.ReadLine();

                if (userForce == "Lumpawaroo")
                    break;

                if (userForce.Contains("|"))
                {

                    string[] force = userForce.Split(" | ");
                    string currentForceSide = force[0];
                    string currentUserName = force[1];

                    if (!sideNameUsers.ContainsKey(currentUserName))
                    {
                        sideNameUsers.Add(currentUserName, currentForceSide);
                    }
                }
                else if (userForce.Contains("->"))
                {
                    string[] force = userForce.Split(" -> ").ToArray();

                    string currentForceSide = force[1];
                    string currentUserName = force[0];

                    if (!sideNameUsers.ContainsKey(currentUserName))
                    {
                        sideNameUsers.Add(currentUserName, currentForceSide);
                    }
                    else
                    {
                        sideNameUsers[currentUserName] = currentForceSide;
                    }

                    joinUser.Add($"{currentUserName } joins the {currentForceSide} side!");
                }
            }

            foreach (string joining in joinUser)
            {
                Console.WriteLine(joining);
            }

            Dictionary<string, IEnumerable<string>> sideResult = sideNameUsers
                .GroupBy(x => x.Value)
                .OrderBy(x => x.Count())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Select(y => y.Key));

            foreach (KeyValuePair<string, IEnumerable<string>> sideNameUser in sideResult)
            {
                Console.WriteLine($"Side: {sideNameUser.Key}, Members: {sideNameUser.Value.Count()}");

                foreach (string user in sideNameUser.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
