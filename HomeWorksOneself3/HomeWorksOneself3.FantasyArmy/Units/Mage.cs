using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public class Mage : Unit
    {
        public int Mana { get; set; }

        public Mage()
        {
        }

        public Mage(string name, bool isAlive, double healthPoints,
            double cost, double armor, string typeOfArmor,
            string side, double damage, string typeOfDamage,
            int luck, int mana)
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
            Mana = mana;
        }
    }
}
