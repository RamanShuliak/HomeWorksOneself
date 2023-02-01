using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorksOneself4.WorkWithFilesAndStrings
{
    public class ParsingMethods
    {
        public List<string> ParsingForSentences(string filePath)
        {

            using(var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var text = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\AllSentences.txt");

                var numberOfSentences = 0;

                var sentences = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    
                    sentences = line.Split('.', '!', '?').ToList();

                    foreach(var sentence in sentences)
                    {
                        if (sentence.Length >= 2)
                        {
                            text.WriteLine($"Sentence - {sentence}");

                            numberOfSentences++;
                        }
                    }
                }

                Console.WriteLine($"Number of sentences in text = {numberOfSentences}");

                return sentences;
            }
        }

        public List<string> ParsingForWords(string filePath)
        {
            using(var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var newText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\AllWords.txt");

                var symbolsForSpleating = new[] { ".", "\"", ",", "!", "?", "'",
                    "-", " ", "", ":", "\t", "\n", ";", "1", "2", "3", "4", "5",
                    "6", "7", "8", "9", "0", "(", ")", "$", "_", "/", ">", "<",
                    "[", "]", "|", "*", "#", "&", "+", "%", "=", "~"};

                // I try to devide text for words by using Regexes [^(A-za-z)] and [^(\w)]
                // but it's didn't bring neded result.

                var words = new List<string>();

                var numberOfWords = 0;

                while (!reader.EndOfStream)
                {
                    var originalText = reader.ReadToEnd();

                    words = originalText.Split(symbolsForSpleating, StringSplitOptions.RemoveEmptyEntries).ToList();

                    words.Sort();

                    foreach (var word in words)
                    {
                        var newWord = word.ToUpperInvariant();

                        newText.WriteLine(newWord);

                        numberOfWords++;
                    }
                }

                Console.WriteLine($"Number of words in text = {numberOfWords}");

                return words;

            }
        }

        public void ParsingForPunctuationMarks(string filePath)
        {
            using(var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                var newText = File.CreateText(@"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\AllPunctuationMarks.txt");

                var numberOfMarks = 0;

                while (!reader.EndOfStream)
                {
                    var originalText = reader.ReadToEnd();

                    var marks = originalText.Where(c => char.IsPunctuation(c)).ToList();

                    foreach(var mark in marks)
                    {
                        newText.WriteLine(mark);

                        numberOfMarks++;
                    }
                }

                Console.WriteLine($"Number of punctuation marks in text = {numberOfMarks}");
            }
        }
    }
}
