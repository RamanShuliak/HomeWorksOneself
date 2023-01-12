using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy.Units
{
    public abstract class Unit : GameObject, IAttack
    {
        public string Side { get; set; }
        public double Damage { get; set; }
        public string TypeOfDamage { get; set; }
        public bool Luck { get; set; }

        public virtual void Attack (Unit attacker, GameObject target)
        {
            if (target is Unit)
            {
                var newTarget = (Unit)target;
                if (attacker.Side == newTarget.Side && attacker.Side == "Light")
                {
                    Console.WriteLine($"Light characters can't fight between themselves," +
                        $"and {attacker.Name} with {target.Name} go to tavern and drink together.");
                }
            }
            Console.WriteLine($"{attacker.Name} attack {target.Name}.");

            target.Attacked(target, attacker);
        }
    }
}
