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

                for (var i = 0; i < words.Count; i++)
                {
                    if (words[i + 1].Equals(words[i]))
                    {
                        words.Remove(words[i + 1]);
                        amountOfWord++;
                    }
                    else
                    {
                        newWordsText.WriteLine($"{words[i]} - {amountOfWord}");
                        amountOfWord = 1;
                    }
                }
            }

            /* var filePath = @"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\AllWords.txt";

             var newWords = new List<WordAndAmount>();

             using (var reader = new StreamReader(filePath, Encoding.UTF8))
             {
                 var newWordsText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\WordsAndAmounts.txt");

                 while (!reader.EndOfStream)
                 {
                     var amountOfWord = 1;

                     for (var i = 0; i < words.Count-1; i++)
                     {
                         if (words[i + 1].Equals(words[i]))
                         {
                             amountOfWord++;
                         }
                         else
                         {
                             var newWord = new WordAndAmount()
                             {
                                 Word = words[i],
                                 Amount = amountOfWord
                             };

                             newWords.Add(newWord);

                             amountOfWord = 1;
                         }
                     }

                     foreach(var word in newWords)
                     {
                         newWordsText.WriteLine($"{word.Word} - {word.Amount}");
                     }*/
        } 
            }
        }
    }
}
