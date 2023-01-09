using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.PassengerTrain.Places
{
    public class SeatPlace : PassengerPlace
    {
        public static int Cost { get; set; }
        public SeatPlace()
        {
            Cost = 30;
        }
    }
}
