using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> sorted = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            while (sorted.Count<n)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                BaseHero hero = CreateHero(heroName,heroType);
                if (hero!=null)
                {
                    
                    sorted.Add(hero);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
            }
            long bossPower = long.Parse(Console.ReadLine());
            foreach (var item in sorted)
            {
                Console.WriteLine(item.CastAbility());
                bossPower -= item.Power;
            }
            if (bossPower<=0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string heroName, string heroType)
        {
            BaseHero hero = null;
            if (heroType == "Druid")
            {
                hero = new Druid(heroName);

            }
            else if (heroType == "Paladin")
            {
                hero = new Paladin(heroName);
            }
            else if (heroType == "Rogue")
            {
                hero = new Rogue(heroName);
            }
            else if (heroType == "Warrior")
            {
                hero = new Warrior(heroName);
            }
            return hero;
        }
    }
}
