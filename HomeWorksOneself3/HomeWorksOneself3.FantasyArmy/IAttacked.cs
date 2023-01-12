using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.FantasyArmy
{
    public interface IAttacked
    {
        void Attacked(GameObject target, Unit attacker);
    }
}
