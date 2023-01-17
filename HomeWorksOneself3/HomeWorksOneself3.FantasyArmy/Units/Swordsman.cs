﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public class Swordsman : Unit
    {
        public int Stamina { get; set; }

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
    }
}
