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

            parsingMethods.ParsingForSentences(filePath);
        }
    }
}