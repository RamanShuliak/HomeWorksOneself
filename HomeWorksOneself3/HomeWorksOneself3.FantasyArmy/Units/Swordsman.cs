using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public class Swordsman : Unit
    {
        public double Stamina { get; set; }

        public Swordsman()
        {
        }

        public Swordsman(string name, bool isAlive, double healthPoints, 
            double cost, double armor, string typeOfArmor, 
            string side, double damage, string typeOfDamage, 
            int luck, int stamina)
        {
            Name = name;
            IsAlive = isAlive;
            HealthPoints = healthPoints;
            Cost = cost;
            Armor = armor;
            TypeOfArmor = typeOfArmor;
            Side = side;
            Damage = damage;
            TypeOfDamage = typeOfDamage;
            Luck = luck;
            Stamina = stamina;
        }

        public override void Attack(GameObject target)
        {
            var costOfHit = 20;

            if(Stamina <= 0)
            {
                Stamina = 0;

                Damage /= 2;
                Console.WriteLine($"{Name} is tired and can't fight at full strength. His hits got weaker.{Environment.NewLine}" +
                    $"{Name}'s damage = {Damage}");
            }

            base.Attack(target);

            Stamina -= costOfHit;

        }

        public override void GetDamage(double damage)
        {
            base.GetDamage(damage);

            if (Armor <= 40)
            {
                Console.WriteLine($"Good warior can't fight in damaged armor. " +
                    $"So, {Name} use a special set fo reparing arms.");

                Armor += 30;

                Console.WriteLine($"{Name} armor = {Armor}.");
            }
        }
    }
}
