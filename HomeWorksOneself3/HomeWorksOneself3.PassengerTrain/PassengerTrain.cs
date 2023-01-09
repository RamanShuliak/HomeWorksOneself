using HomeWorksOneself3.PassengerTrain.Carriages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.PassengerTrain
{
    public class PassengerTrain : Train
    {
        public int PassengersAmount { get; set; }
        public Сarriage[]? Carriages { get; set; }
    }
}
