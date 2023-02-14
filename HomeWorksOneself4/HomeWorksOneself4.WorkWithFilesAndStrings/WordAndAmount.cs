using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself4.WorkWithFilesAndStrings
{
    public class WordAndAmount
    {
        public string Word { get; set; }
        public int Amount { get; set; }

        public WordAndAmount(string word, int amount)
        {
            Word = word;
            Amount = amount;
        }

        public WordAndAmount()
        {
        }
    }
}
