using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public abstract class Unit : GameObject, IAttack, IFight, ILucky
    {
        public string Side { get; set; }
        public double Damage { get; set; }
        public string TypeOfDamage { get; set; }
        public int Luck { get; set; }

        public virtual void Attack (GameObject target)
        {
            var resultDamage = 0.0;

            if (TypeOfDamage == "Physical" && target.TypeOfArmor == "Magic")
            {
                Console.WriteLine($"Physical weapon deal half damage to the magic armor.");
                resultDamage = Damage / 2 - target.Armor;
            }
            else if (TypeOfDamage == "Magic" && target.TypeOfArmor == "Physical")
            {
                Console.WriteLine($"Magic weapon deal one and half damage to the physical armor.");
                resultDamage = Damage * 1.5 - target.Armor;
            }
            else
            {
                resultDamage = Damage - target.Armor;
            }

            var luckInAttack = CalculateLuck();

            resultDamage *= luckInAttack;

            target.GetDamage(resultDamage);
        }

        public void Fight(Unit opponent)
        {
            while(IsAlive == true && opponent.IsAlive == true)
            {
                if (Side == opponent.Side && Side == "Light")
                {
                    Console.WriteLine($"Light characters can't fight between themselves.{Environment.NewLine}" +
                        $"{Name} with {opponent.Name} desided, that they don't wants to kill each other " +
                        $"and go to tavern to drink  beer together.");

                    break;
                }
                else
                {
                    Attack(opponent);

                    if (opponent.IsAlive == true)
                    {
                        opponent.Attack(this);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if(IsAlive == false)
            {
                Console.WriteLine($"{opponent.Name} won the {Name} in fight.{Environment.NewLine}" +
                    $"{Name}'s body was thrown to the crows.");
            }
            else if(opponent.IsAlive == false)
            {
                Console.WriteLine($"{Name} won the {opponent.Name} in fight.{Environment.NewLine}" +
                    $"{opponent.Name}'s body was thrown to the crows.");
            }
        }

        public double CalculateLuck()
        {
            var random = new Random();

            var univerceLuck = random.Next(0, 100);

            var resultLuck = ((double)((Luck + univerceLuck)/2)/100);

            return resultLuck;
        }
    }
}
