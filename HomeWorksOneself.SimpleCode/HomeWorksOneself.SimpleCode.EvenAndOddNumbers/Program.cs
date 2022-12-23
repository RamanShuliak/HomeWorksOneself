namespace HomeWorksOneself.SimpleCode.EvenAndOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can to calculate the amount of the" +
                              "even and odd numbers in range entered by user," +
                              $"and print the result of their addition.{Environment.NewLine}");
            Console.WriteLine("Attention! You should enter to the console only integer " +
                              "numbers from -2,147,483,648 to 2,147,483,647.");

            ChekEnteredData();
        }

        static string EnterBordersOfRange()
        {

            var border = Console.ReadLine();

            return border;

        }

        static void ChekEnteredData()
        {
            Console.WriteLine("Enter minimal border:");
            var minimalBorder = EnterBordersOfRange();

            Console.WriteLine("Enter maximal border:");
            var maximalBorder = EnterBordersOfRange();

            if (int.TryParse(minimalBorder, out int chekedMinimalBorder) &&
                int.TryParse(maximalBorder, out int chekedMaximalBorder))
            {

                GivenBordersOfRange(chekedMinimalBorder, chekedMaximalBorder);

            }
            else
            {
                Console.WriteLine("Entered data are wrong. You should to enter " +
                                  "integer numbers from -2,147,483,648 to 2,147,483,647." +
                                  "Try again.");
                ChekEnteredData();
            }

        }

        static void GivenBordersOfRange(int chekedMinimalBorder, int chekedMaximalBorder)
        {

            if (chekedMinimalBorder >= chekedMaximalBorder)
            {
                Console.WriteLine("Minimal border can't be bigger or equals maximal border. Enter borders again.");
                ChekEnteredData();
            }
            else
            {
                CalculateNumbers(chekedMinimalBorder, chekedMaximalBorder);
                ContinueOrNot();
            }
        }

        static void CalculateNumbers(int chekedMinimalBorder, int chekedMaximalBorder)
        {
            var evenNumbersSumResult = 0;

            var evenNumbersAmount = 0;

            var oddNumbersSumResult = 0;

            var oddNumbersAmount = 0;

            for (int i = chekedMinimalBorder; i <= chekedMaximalBorder;  i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbersAmount++;

                    evenNumbersSumResult = evenNumbersSumResult + i;
                }
                else
                {
                    oddNumbersAmount++;

                    oddNumbersSumResult = oddNumbersSumResult + i;
                }
            }

            Console.WriteLine($"Amount of even numbers in entered range is {evenNumbersAmount}.{Environment.NewLine}" +
                              $"Addition of even numbers in entered range if {evenNumbersSumResult}." +
                              $"{Environment.NewLine}{Environment.NewLine}" +
                              $"Amount of odd numbers in entered range is {oddNumbersAmount}.{Environment.NewLine}" +
                              $"Addition of odd numbers in entered range if {oddNumbersSumResult}");
        }

        static void ContinueOrNot()
        {
            Console.WriteLine("Enter Y if you wont to continue program," +
                              "or N if you wont to close it.");

            var select = Convert.ToString(Console.ReadLine());

            var newSelect = select.ToUpperInvariant();

            switch (newSelect)
            {
                case ("Y"):
                    ChekEnteredData();
                    break;
                case ("N"):
                    Console.WriteLine("Program end. Goodby :-)");
                    break;
                default:
                    Console.WriteLine("Entered data is wrong. Try again.");
                    ContinueOrNot();
                    break;
            }
        }
    }
}