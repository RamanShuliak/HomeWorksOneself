using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorksOneself4.WorkWithFilesAndStrings
{
    public class ParsingMethods
    {
        public void ParsingForSentences(string filePath)
        {

            using(var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var text = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\Sentences.txt");

                var numberOfSentences = 0;

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var sentences = line.Split('.', '!', '?');

                    foreach(var sentence in sentences)
                    {
                        if (sentence.Length >= 2)
                        {
                            text.WriteLine($"New sentence - {sentence}");

                            numberOfSentences++;
                        }
                    }
                }

                Console.WriteLine($"Number of sentences in text = {numberOfSentences}");
            }
        }

        public void ParsingForWords(string filePath)
        {
            using(var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var newText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\Words.txt");

                var originalText = reader.ReadToEnd();

                var words = originalText.Split(" ");

                var symbolsForReplacing = new[] { ".", "\"", ",", "!", "?", "'", "-"};

                var numberOfWords = 0;

                foreach(var word in words)
                {
                    var cleanWord = "";
                    foreach(var symbol in symbolsForReplacing)
                    {
                        cleanWord = word.Replace(symbol, "");
                    }

                    var newWord = cleanWord.ToUpperInvariant();

                    newText.WriteLine(newWord);

                    numberOfWords++;
                }

                Console.WriteLine($"Number of words in text = {numberOfWords}");

            }
        }
    }
}
