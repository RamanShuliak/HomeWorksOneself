using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorksOneself3.FantasyArmy.Units;

namespace HomeWorksOneself3.FantasyArmy
{
    public class Army
    {
        public List<Unit> Units { get; set; }
        public Army(List<Unit> units)
        {
            Units = units;
        }
    }
}
