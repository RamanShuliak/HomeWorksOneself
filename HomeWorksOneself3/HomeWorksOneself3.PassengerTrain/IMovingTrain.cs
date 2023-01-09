using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.PassengerTrain
{
    public interface IMovingTrain
    {
        public void Move(int distance, string destination, Train train);
    }
}
