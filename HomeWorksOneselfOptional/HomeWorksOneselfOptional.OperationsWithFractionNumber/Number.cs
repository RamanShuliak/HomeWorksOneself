using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneselfOptional.OperationsWithFractionNumber
{
    public class Number
    {
        public string Name { get; set; }
        public long IntegerPart { get; set; }

        public ushort[] FractionalPart { get; set; }

        public Number( string name, long integerPart, ushort[] fractionPart)
        {
            Name = name;
            IntegerPart = integerPart;
            FractionalPart = fractionPart;
        }

        public void PrintNumber()
        {
            var str = "";

            foreach (var fract in FractionalPart)
            {
                str += fract;
            }

            Console.WriteLine($"{Name} = {IntegerPart}.{str}");
        }
    }
}
