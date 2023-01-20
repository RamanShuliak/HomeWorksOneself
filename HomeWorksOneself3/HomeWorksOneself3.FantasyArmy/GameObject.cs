using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorksOneself3.FantasyArmy.Units;

namespace HomeWorksOneself3.FantasyArmy
{
    public abstract class GameObject : IDamaged
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public double HealthPoints { get; set; }
        public double Cost { get; set; }
        public double Armor { get; set; }
        public string TypeOfArmor { get; set; }

        public virtual void GetDamage(double damage)
        {
            if(damage < 0)
            {
                damage = 0;
            }

            HealthPoints -= damage;

            Armor *= 0.85;

            if (HealthPoints <= 0)
            {
                if (this is Unit)
                {
                    Console.WriteLine($"{Name} was kiled.");
                }
                else
                {
                    Console.WriteLine($"{Name} was distruct.");
                }

                IsAlive = false;
            }
            else
            {
                Console.WriteLine($"{Name} was damaged by {damage} points.{Environment.NewLine}" +
                    $"{Name}'s health = {HealthPoints}.");
            }
        }
    }
}
