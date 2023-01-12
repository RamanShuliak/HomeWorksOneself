using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy
{
    public abstract class GameObject : IAttacked
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public double Cost { get; set; }
        public int Armor { get; set; }
        public string TypeOfArmor { get; set; }

        public void Attacked(GameObject target, Unit attacker)
        {
            var resultDamage = attacker.Damage - target.Armor;

            if (attacker.TypeOfDamage == "Physical" && target.TypeOfArmor == "Magic")
            {
                Console.WriteLine($"Damage dealt by physical weapon to." +
                    $"Amount of damage = 0.");
            }
            else if (attacker.TypeOfDamage == "Physical" && target.TypeOfArmor == "Magic")
            {

            }



        }
    }
}
