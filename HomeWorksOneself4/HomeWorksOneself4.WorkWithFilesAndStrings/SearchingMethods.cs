using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself4.WorkWithFilesAndStrings
{
    public class SearchingMethods
    {
        public void PrintWordsListWithAmounts(List<string> words)
        {

            using (var writer = new StringWriter())
            {
                var newWordsText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\WordsAndAmounts.txt");

                var resultWords = words.GroupBy(w => w)
                              .Where(w => w.Count() > 0)
                              .Select(w => new WordAndAmount{ Word = w.Key, Amount = w.Count() })
                              .ToList();

                foreach(var word in resultWords) 
                {
                    newWordsText.WriteLine($"{word.Word} - {word.Amount}");
                }
            }
        }
    }
}
