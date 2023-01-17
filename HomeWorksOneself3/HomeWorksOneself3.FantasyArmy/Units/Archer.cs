using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public class Archer : Unit
    {
        public int AmountOfArrows { get; set; }

        public Archer()
        {
        }

        public Archer(string name, bool isAlive, double healthPoints,
            double cost, double armor, string typeOfArmor,
            string side, double damage, string typeOfDamage,
            int luck, int amountOfArrows)
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
            AmountOfArrows = amountOfArrows;
        }
    }
}
