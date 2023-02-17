using System.Diagnostics.Tracing;
using System.Text;
namespace HomeWorksOneself4.WorkWithFilesAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = 
                @"D:\Programming\Repository\HomeWorksOneself\HomeWorksOneself4\WorkingFiles\SampleForHomeWork4.txt";

            var parsingMethods = new ParsingMethods();

            var sentences = parsingMethods.ParsingForSentences(filePath);

            var words = parsingMethods.ParsingForWords(filePath);

            parsingMethods.ParsingForPunctuationMarks(filePath);


            var searchingMethods = new SearchingMethods();

            searchingMethods.PrintWordsListWithAmounts(words);

            searchingMethods.FindMaxBySymbolsSentence(sentences);
        }
    }
}