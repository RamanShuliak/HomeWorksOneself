namespace HomeWorksOneself1.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program give you multiplication table of numbers, " +
                              $"thats you will enter.{Environment.NewLine}");
            EnterData();
        }

        static void EnterData()
        {
            var rightNumber = 0.0;

            Console.WriteLine($"Please, enter the number{Environment.NewLine}");

            var number = Console.ReadLine();

            if (double.TryParse(number, out rightNumber))
            {
                PrintMultiplicationTable(rightNumber);
            }
            else
            {
                Console.WriteLine($"Entered data is wrong. Try again{Environment.NewLine}");

                ContinueOrNot();
            }
        }

        static void ContinueOrNot()
        {
            Console.WriteLine($"Do you want yo continue? Y/N{Environment.NewLine}");

            var continueOrNot = Console.ReadLine();
            if (continueOrNot.ToUpperInvariant() == "Y")
            {
                EnterData();
            }
            else if (continueOrNot.ToUpperInvariant() == "N")
            {
                Console.WriteLine("Program end. Goodby :-)");
            }
            else
            {
                Console.WriteLine($"Entered data is wrong. Try again{Environment.NewLine}");

                ContinueOrNot();
            }
        }

        static void PrintMultiplicationTable(double rightNumber)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{rightNumber} * {i} = {rightNumber * i}");
            }
            Console.WriteLine($"{Environment.NewLine}");
            ContinueOrNot();
        }
    }
}