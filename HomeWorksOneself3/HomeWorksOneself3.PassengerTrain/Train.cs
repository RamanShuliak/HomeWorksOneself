using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself3.PassengerTrain
{
    public abstract class Train : IMovingTrain
    {
        public string Id { get; set; }
        public string TravelDirection { get; set; }
        public int Speed { get; set; }

        public void Move(int distance, string destination, Train train)
        {
            var time = (double)(distance / train.Speed);

            Console.WriteLine($"Train {train.TravelDirection} number {train.Id} arrived " +
                $"on {destination} in {time} hours");
        }
    }
}
