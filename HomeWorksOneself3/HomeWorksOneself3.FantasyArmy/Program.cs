using HomeWorksOneself3.FantasyArmy.Units;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace HomeWorksOneself3.FantasyArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mage = new Mage()
            {
                Name = "Mage Yalzud-Gur",
                IsAlive = true,
                HealthPoints = 50.0,
                Cost = 300,
                Armor = 45,
                TypeOfArmor = "Magic",
                Side = "Light",
                Damage = 100,
                TypeOfDamage = "Magic",
                Luck = 40,
                Mana = 100
            };

            var swordsman = new Swordsman()
            {
                Name = "Swordsman Magnus",
                IsAlive = true,
                HealthPoints = 100.0,
                Cost = 150,
                Armor = 70,
                TypeOfArmor = "Physical",
                Side = "Dark",
                Damage = 80,
                TypeOfDamage = "Physical",
                Luck = 50,
                Stamina = 80
            };

            var archer = new Archer()
            {
                Name = "Archer Legolas",
                IsAlive = true,
                HealthPoints = 80.0,
                Cost = 200,
                Armor = 55,
                TypeOfArmor = "Physical",
                Side = "Neutral",
                Damage = 90,
                TypeOfDamage = "Physical",
                Luck = 55,
                AmountOfArrows = 15
            };

            archer.Fight(swordsman);
        }
    }
}