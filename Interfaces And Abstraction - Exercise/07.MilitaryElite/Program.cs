
using Military.Nums;
using Military.Podels;
using Military.Pontracts;
using MilitaryEliteFinal.Models;
using System;
using System.Collections.Generic;

namespace MilitaryEliteFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] input = line.Split();
                string type = input[0];
                string id = input[1];
                string firstName = input[2];
                string lastName = input[3];
                if (type == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers[id] = @private;
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 5; i < input.Length; i++)
                    {
                        string privateId = input[i];
                        if (!soldiers.ContainsKey(privateId))
                        {
                            continue;
                        }
                        lieutenantGeneral.Add((IPrivate)soldiers[privateId]);
                    }
                    soldiers[id] = lieutenantGeneral;
                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    bool isCorpsValid = Enum.TryParse(input[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < input.Length; i += 2)
                    {
                        IRepair repair = new Repair(input[i], int.Parse(input[i + 1]));
                        engineer.Add(repair);
                    }
                    soldiers[id] = engineer;
                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);
                    bool isCorpsValid = Enum.TryParse(input[5], out Corps corps);
                    if (!isCorpsValid)
                    {
                        continue;
                    }
                    ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                    for (int i = 6; i < input.Length; i+=2)
                    {
                        bool isStateValid = Enum.TryParse(input[i + 1], out State state);
                        if (!isStateValid)
                        {
                            continue;
                        }
                        IMission mission = new Mission(input[i], state);
                        commando.Add(mission);
                    }
                    soldiers[id] = commando;
                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(input[4]);
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers[id] = spy;
                }
            }
            foreach (var item in soldiers.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
