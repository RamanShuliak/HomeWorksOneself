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

                var symbolsForSpleating = new string[] 
                { 
                    ". ", 
                    "? ", 
                    "! ",
                    "\n", 
                    "\" ",
                    ".\n",
                    "?\n",
                    "!\n",
                    "...",
                    "?!",
                    "?..",
                    "!.."
                };

                while (!reader.EndOfStream)
                {
                    var allText = reader.ReadToEnd();

                    sentences = allText
                        .Split(symbolsForSpleating, StringSplitOptions.RemoveEmptyEntries)
                        .Where(s => s != null || s.Count() != 0)
                        .Select(s => s)
                        .ToList();


                    foreach (var sentence in sentences)
                    {
                            text.WriteLine($"* - {sentence}");

                            numberOfSentences++;
                    }
                }

                Console.WriteLine($"Number of sentences in text = {numberOfSentences}");

                text.Close();

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

                // I try to devide given by teacher text for words
                // by using Regexes [^(A-za-z)] and [^(\w)]
                // but it's didn't bring neded result.

                var words = new List<string>();

                while (!reader.EndOfStream)
                {
                    var originalText = reader.ReadToEnd();

                    words = originalText
                        .Split(symbolsForSpleating, StringSplitOptions.RemoveEmptyEntries)
                        .Select(w => w.ToUpperInvariant())
                        .OrderBy(w => w)
                        .ToList();

                    foreach(var word in words)
                    {
                        newText.WriteLine(word);
                    }
                }
                var numberOfWords = words.Count();

                Console.WriteLine($"Number of words in text = {numberOfWords}");

                newText.Close();

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
