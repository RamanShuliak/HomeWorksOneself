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

        public void FindMaxBySymbolsSentence(List<string> sentences)
        {
                var sentencesResultText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\SentencesResultText.txt");

                var maxBySymbolsSentence = sentences
                    .OrderByDescending(w => w.Count())
                    .FirstOrDefault();

                sentencesResultText.Write(maxBySymbolsSentence);

        }
    }
}
