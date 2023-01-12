using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorksOneself3.FantasyArmy.Units;

namespace HomeWorksOneself3.FantasyArmy
{
    public abstract class GameObject : IAttacked
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public double HealthPoints { get; set; }
        public double Cost { get; set; }
        public double Armor { get; set; }
        public string TypeOfArmor { get; set; }

        public void Attacked(GameObject target, Unit attacker)
        {
            var resultDamage = 0.0;

            if (attacker.TypeOfDamage == "Physical" && target.TypeOfArmor == "Magic")
            {
                Console.WriteLine($"Physical weapon deal half damage to the magic armor.");
                resultDamage = attacker.Damage / 2 - target.Armor;
            }
            else if (attacker.TypeOfDamage == "Magic" && target.TypeOfArmor == "Physical")
            {
                Console.WriteLine($"Magic weapon deal one and half damage to the physical armor.");
                resultDamage = attacker.Damage * 1.5 - target.Armor;
            }
            else
            {
                resultDamage = attacker.Damage - target.Armor;
            }

            target.HealthPoints -= resultDamage;

            if(target.HealthPoints <= 0)
            {
                if(target is Unit)
                {
                    Console.WriteLine($"{target.Name} was kiled.");
                }
                else
                {
                    Console.WriteLine($"{target.Name} was distruct.");
                }

                target.IsAlive = false;
            }
            else
            {
                Console.WriteLine($"{target.Name} was damaged by {resultDamage} points.{Environment.NewLine}" +
                    $"{target.Name}'s health = {target.HealthPoints}.");
            }

        }
    }
}
