using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorksOneself3.FantasyArmy.Units;

namespace HomeWorksOneself3.FantasyArmy
{
    public interface IAttack
    {
        void Attack (Unit attacker, GameObject target);
    }
}
