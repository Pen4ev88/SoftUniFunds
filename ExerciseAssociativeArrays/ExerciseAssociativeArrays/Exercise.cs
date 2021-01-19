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

        public void SoftUniParking()
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

        public void Courses()
        {
            var courcesDict = new Dictionary<string, List<string>>();
            string[] cource = new string[2];

            do
            {
                cource = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();

                if (cource[0] == "end")
                    break;

                if (!courcesDict.ContainsKey(cource[0]))
                {
                    courcesDict[cource[0]] = new List<string>();
                    courcesDict[cource[0]].Add(cource[1]);
                }
                else
                {
                    courcesDict[cource[0]].Add(cource[1]);
                }

            }
            while (true);

            var courceDictFinal = courcesDict.Select(c => c)
                                             .OrderByDescending(c => c.Value.Count())
                                             .ToDictionary(c => c.Key, c => c.Value);

            foreach (var kvp in courceDictFinal)
            {
                Console.Write($"{kvp.Key}: {kvp.Value.Count()}\n");
                foreach (var item in kvp.Value.OrderBy(n => n))
                {
                    Console.Write($"-- {item}\n");
                }
            }
        }

        public void StudentAcademy()
        {
            var studentDict = new Dictionary<string, List<double>>();

            var students = int.Parse(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (!studentDict.ContainsKey(name))
                {
                    studentDict[name] = new List<double>();
                    //studentDict[name].Add(grade);
                }
                studentDict[name].Add(grade);
            }

            Console.WriteLine(string.Join("\n", studentDict
                                   .Where(s => (s.Value.Sum() / s.Value.Count) >= 4.5)
                                   .OrderByDescending(s => s.Value.Sum() / s.Value.Count)
                                   .Select(s => $"{s.Key} -> {s.Value.Sum() / s.Value.Count():F2}")));
        }

        public void CompanyUser()
        {
            var companyDict = new Dictionary<string, List<string>>();

            while (true)
            {
                var company = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();                

                if (company[0] == "End")
                    break;

                if (!companyDict.ContainsKey(company[0]))
                {
                    companyDict[company[0]] = new List<string>();
                    companyDict[company[0]].Add(company[1]);
                }
                else 
                {
                    if (!companyDict[company[0]].Contains(company[1]))
                    {
                        companyDict[company[0]].Add(company[1]);
                    }
                }
            }

            companyDict = companyDict.OrderBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);

            foreach (var company in companyDict.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }

        public void ForceBook()
        {
            var forceSide = new SortedDictionary<string, string>();
            var sideTranslate = new Dictionary<string, string>();

            var sideMember = new SortedDictionary<string, int>();

            while (true)
            {
                var userForce = Console.ReadLine();

                if (userForce == "Lumpawaroo")
                    break;

                if (userForce.Contains("|"))
                {

                    var force = userForce.Split(" | ").ToArray();

                    // COUNT MEMBER
                    if (!sideMember.ContainsKey(force.First()))
                    {
                        sideMember[force.First()] = 1;
                    }
                    else
                    {
                        sideMember[force.First()]++;
                    }

                    // Add side members
                    if (!forceSide.ContainsKey(force.First()))
                    {
                        forceSide[force.Last()] = "";
                        forceSide[force.Last()] = force.First();
                    }
                    else
                    {
                        if (!forceSide[force.Last()].Contains(force.First()))
                        {
                            forceSide[force.Last()] = force.First();
                        }
                    }
                }
                if (userForce.Contains(">"))    // change SIDE or Create new Force User
                {
                    var forceTrance = userForce.Split(" -> ").ToArray();

                    if (!forceSide.ContainsKey(forceTrance.First())) // create new user
                    {
                        forceSide[forceTrance.First()] = forceTrance.Last();

                        if (!sideMember.ContainsKey(forceTrance.Last()))
                        {
                            sideMember[forceTrance.Last()] = 1;
                        }
                        else
                        {
                            sideMember[forceTrance.Last()]++;
                        }
                    }
                    else // remove user from his SIDE and add to Oposite Side
                    {
                        forceSide.Remove(forceTrance.First());

                        forceSide[forceTrance.First()] = forceTrance.Last();
                        sideMember[forceTrance.Last().ToString()]++;
                    }

                    if (!sideTranslate.ContainsKey(forceTrance.First()))
                    {
                        sideTranslate[forceTrance.First()] = "";
                        sideTranslate[forceTrance.First()] = forceTrance.Last();
                    }
                    else
                    {
                        if (!sideTranslate[forceTrance.First()].Contains(forceTrance.Last()))
                        {
                            sideTranslate[forceTrance.First()] = forceTrance.Last();
                        }
                    }
                }
            }

            foreach (var usr in sideTranslate)
            {
                Console.WriteLine($"{usr.Key } joins the {usr.Value} side!");
            }       

            var someSide = forceSide.OrderBy(f => f.Value).ToDictionary(f => f.Key, f => f.Value);

            if (someSide.Values.First() == someSide.Values.Last())
            { 
                Console.Write("Side: ");
                Console.WriteLine($"{someSide.Values.First()}, Members: {someSide.Values.Count}");

                foreach (var usr in forceSide.OrderBy(c => c.Key))
                {
                    Console.WriteLine($"! {usr.Key}");
                }
            }
            else
            {
                var sideL = someSide.Values.First();
                var sideR = someSide.Values.Last();

                var memberCountL = forceSide.Where(f => f.Value == sideL).Count();
                Console.Write("Side: ");
                Console.WriteLine($"{sideL}, Members: {memberCountL}");
                                
                foreach (var usr in someSide.Where(s => s.Value == sideL))
                {
                    Console.WriteLine($"! {usr.Key}");
                }

                var memberCountR = forceSide.Where(f => f.Value == sideR).Count();
                Console.Write("Side: ");
                Console.WriteLine($"{sideR}, Members: {memberCountR}");

                foreach (var usr in someSide.Where(s => s.Value == sideR))
                {
                    Console.WriteLine($"! {usr.Key}");
                }
            }            
        }

        public void SoftUniExam()
        {
            var resultExam = new Dictionary<string, List<int>>();

            var submission = new SortedDictionary<string, int>();

            var langDict = new SortedDictionary<string, int>();

            while (true)
            {
                bool ban = false;

                var input = Console.ReadLine();

                if (input == "exam finished")
                    break;
                
                var studentRes = input.Split("-");
                var nameLang = studentRes[0];
                string lang = "";
                int grade = 0;

                if (!input.Contains("banned"))
                {
                    lang = studentRes[1];
                    grade = int.Parse(studentRes[2]);

                    if (!resultExam.ContainsKey(nameLang))
                    {
                        resultExam[nameLang] = new List<int>();
                        resultExam[nameLang].Add(grade);
                    }
                    else 
                    {
                        resultExam[nameLang].Add(grade);
                    }

                    if (!langDict.ContainsKey(lang))
                    {
                        langDict[lang] = 1;
                    }
                    else
                    { 
                        langDict[lang]++;                        
                    }

                }
                else
                { 
                    ban = true; 

                    foreach (var item in resultExam.Where(kvp => kvp.Key.StartsWith(studentRes[0])).ToList())
                    {
                        resultExam.Remove(item.Key);
                    }
                }            
            }

            var resultMax = new SortedDictionary<string, int>();
            foreach (var user in resultExam)
            {
                if (!resultMax.ContainsKey(user.Key))
                {
                    resultMax[user.Key] = user.Value.Select(s => s).Max();
                }
            }

            Console.WriteLine("Results:");

            var resultMaxF = resultMax.OrderByDescending(r => r.Value).ToDictionary(r => r.Key, r => r.Value);

            foreach (var user in resultMaxF)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var l in langDict)
            {
                Console.WriteLine($"{l.Key} - {l.Value}");
            }

        }

    }
}
