namespace HomeWorksOneself2.MathematicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the console calculator.");

            SelectSourceOfNumbers();
        }

        //________________________SELECTIONS METHODS___________________________________

        static void SelectSourceOfNumbers()
        {
            Console.WriteLine($"Select, do you wont:{Environment.NewLine}" +
                              $"to enter numbers for operations by yourself (enter 1 to console), or{Environment.NewLine}" +
                              $"generate them randomly (enter 2 to console)?");

            var enterSelection = Console.ReadLine();

            if (int.TryParse(enterSelection, out int selectionInt))
            {
                switch (selectionInt)
                {
                    case 1:
                        ChekEnteredData();
                        break;
                    case 2:
                        GetNumbersByRandomAndStartCalculator();
                        break;
                    default:
                        Console.WriteLine("The are no operation with such number. Try again.");
                        SelectSourceOfNumbers();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entered data is wrong. Try again.");
                SelectSourceOfNumbers();
            }

        }

        static void SelectMathOperations(int chekedNumberX, int chekedNumberY)
        {
            Console.WriteLine($"Select math operation:{Environment.NewLine}" +
                              $"1. X + Y{Environment.NewLine}" +
                              $"2. X - Y{Environment.NewLine}" +
                              $"3. X * Y{Environment.NewLine}" +
                              $"4. X / Y{Environment.NewLine}" +
                              $"5. X ^ Y{Environment.NewLine}" +
                              $"6. !X, !Y");

            var enterSelection = Console.ReadLine();

            if (int.TryParse(enterSelection, out int selectionInt))
            {
                switch (selectionInt)
                {
                    case 1:
                        Addition(chekedNumberX, chekedNumberY);
                        break;
                    case 2:
                        Subtraction(chekedNumberX, chekedNumberY);
                        break;
                    case 3:
                        Multiplication(chekedNumberX, chekedNumberY);
                        break;
                    case 4:
                        Dividing(chekedNumberX, chekedNumberY);
                        break;
                    case 5:
                        Rising(chekedNumberX, chekedNumberY);
                        break;
                    case 6:
                        Factorial(chekedNumberX, chekedNumberY);
                        break;
                    default:
                        Console.WriteLine($"{Environment.NewLine}" +
                                          $"Operation with such number is not found.{Environment.NewLine}" +
                                          $"Try again{Environment.NewLine}");
                        SelectMathOperations(chekedNumberX, chekedNumberY);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entered data is wrong. Try again.");
                SelectMathOperations(chekedNumberX, chekedNumberY);
            }
        }

        static void ContinueOrNot()
        {
            Console.WriteLine($"Select, do you want to continue the working of the program? " +
                              $"(Enter Y if yes, or N if no)");

            var selection = Console.ReadLine();

            if (selection.ToUpperInvariant() == "Y")
            {
                SelectSourceOfNumbers();
            }
            else if (selection.ToUpperInvariant() == "N")
            {
                Console.WriteLine("Program end. Goodby :-)");
            }
            else
            {
                Console.WriteLine("Entered data is wrong. Try again.");
                ContinueOrNot();
            }
        }

        //________________________GETTING NUMBERS METHODS___________________________________

        static void GetNumbersByRandomAndStartCalculator()
        {
            var chekedNumberX = GetRandomNumber();
            var chekedNumberY = GetRandomNumber();

            Console.WriteLine($"Number X = {chekedNumberX}      Number Y = {chekedNumberY}");

            SelectMathOperations(chekedNumberX, chekedNumberY);
        }

        static string EnterNumber()
        {
            var number = Console.ReadLine();

            return number;

        }

        static void ChekEnteredData()
        {
            Console.WriteLine("Enter number X:");
            var numberX = EnterNumber();

            Console.WriteLine("Enter number Y:");
            var numberY = EnterNumber();

            if (int.TryParse(numberX, out int chekedNumberX) &&
                int.TryParse(numberY, out int chekedNumberY))
            {

                GetNumbersByUserAndStartCalculator(chekedNumberX, chekedNumberY);

            }
            else
            {
                Console.WriteLine("Entered data are wrong. You should to enter " +
                                  "integer numbers from -2,147,483,648 to 2,147,483,647." +
                                  "Try again.");
                ChekEnteredData();
            }
        }
        static void GetNumbersByUserAndStartCalculator(int chekedNumberX, int chekedNumberY)
        {

            Console.WriteLine($"Number X = {chekedNumberX}      Number Y = {chekedNumberY}");

            SelectMathOperations(chekedNumberX, chekedNumberY);
        }

        static int GetRandomNumber()
        {
            var random = new Random();

            var number = random.Next();

            return number;
        }

        //________________________MATH OPERATIONS METHODS___________________________________

        static void Addition(int chekedNumberX, int chekedNumberY)
        {
            var numberA = (long)chekedNumberX + chekedNumberY;
            Console.WriteLine($"X + Y = {numberA}");

            ContinueOrNot();
        }

        static void Subtraction(int chekedNumberX, int chekedNumberY)
        {
            Console.WriteLine($"X - Y = {chekedNumberX - chekedNumberY}");

            ContinueOrNot();
        }

        static void Multiplication(int chekedNumberX, int chekedNumberY)
        {
            var numberA = (long)chekedNumberX * chekedNumberY;
            Console.WriteLine($"X * Y = {numberA}");

            ContinueOrNot();
        }

        static void Dividing(int chekedNumberX, int chekedNumberY)
        {
            var numberA = (double)chekedNumberX / chekedNumberY;
            Console.WriteLine($"X / Y = {numberA}");

            ContinueOrNot();
        }

        static void Rising(int chekedNumberX, int chekedNumberY)
        {
            var numberA = Math.Pow(chekedNumberX, chekedNumberY);

            if (numberA <= double.MaxValue)
            {
                Console.WriteLine($"X ^ Y = {numberA}");
            }
            else
            {
                Console.WriteLine("Sorry, but result of this operation is so big for print in this calculator." +
                                  "Try again.");
                ContinueOrNot();
            }
            ContinueOrNot();
        }

        static void Factorial(int chekedNumberX, int chekedNumberY)
        {
            long factorialX = 1;
            for (int i = 1; i <= chekedNumberX; i++)
            {
                factorialX *= i;
            }

            long factorialY = 1;
            for (int x = 1; x <= chekedNumberY; x++)
            {
                factorialY *= x;
            }

            if (factorialX <= 0)
            {
                Console.WriteLine(
                    $"Factorial X - Sorry, but result of this operation is so big for print in this calculator.");
            }
            else
            {
                Console.WriteLine($"Factorial X = {factorialX}{Environment.NewLine}");
            }

            if (factorialY <= 0)
            {
                Console.WriteLine(
                    $"Factorial Y - Sorry, but result of this operation is so big for print in this calculator.");
            }
            else
            {
                Console.WriteLine($"Factorial Y = {factorialY}{Environment.NewLine}");
            }

            ContinueOrNot();
        }
    }
}