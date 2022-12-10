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
                        GetNumbersByUserAndStartCalculator();
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

        static void SelectMathOperations(int numberX, int numberY)
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
                        Addition(numberX, numberY);
                        break;
                    case 2:
                        Subtraction(numberX, numberY);
                        break;
                    case 3:
                        Multiplication(numberX, numberY);
                        break;
                    case 4:
                        Dividing(numberX, numberY);
                        break;
                    case 5:
                        Rising(numberX, numberY);
                        break;
                    case 6:
                        Factorial(numberX, numberY);
                        break;
                    default:
                        Console.WriteLine($"{Environment.NewLine}" +
                                          $"Operation with such number is not found.{Environment.NewLine}" +
                                          $"Try again{Environment.NewLine}");
                        SelectMathOperations(numberX, numberY);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entered data is wrong. Try again.");
                SelectMathOperations(numberX, numberY);
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

        static void GetNumbersByUserAndStartCalculator()
        {
            Console.WriteLine("Attention! You should enter to the console only integer numbers from" +
                              "-2,147,483,648 to 2,147,483,647.");
            Console.WriteLine("Enter number X:");
            var numberX = EnterNumber();

            Console.WriteLine("Enter number Y:");
            var numberY = EnterNumber();

            Console.WriteLine($"Number X = {numberX}      Number Y = {numberY}");

            SelectMathOperations(numberX, numberY);
        }

        static void GetNumbersByRandomAndStartCalculator()
        {
            var numberX = GetRandomNumber();
            var numberY = GetRandomNumber();

            Console.WriteLine($"Number X = {numberX}      Number Y = {numberY}");

            SelectMathOperations(numberX, numberY);
        }

        static int EnterNumber()
        {
            var enterData = Console.ReadLine();

            if (int.TryParse(enterData, out int enterNumber))
            {
                return enterNumber;
            }
            else
            {
                Console.WriteLine("Entered data is wrong. You should enter only integer numbers from" +
                              "-2,147,483,648 to 2,147,483,647.Try again.");
                EnterNumber();
            }

            return 0;

        }

        static int GetRandomNumber()
        {
            var random = new Random();

            var number = random.Next();

            return number;
        }

        //________________________MATH OPERATIONS METHODS___________________________________

        static void Addition(int numberX, int numberY)
        {
            var numberA = (long)numberX + numberY;
            Console.WriteLine($"X + Y = {numberA}");

            ContinueOrNot();
        }

        static void Subtraction(int numberX, int numberY)
        {
            Console.WriteLine($"X - Y = {numberX - numberY}");

            ContinueOrNot();
        }

        static void Multiplication(int numberX, int numberY)
        {
            var numberA = (long)numberX * numberY;
            Console.WriteLine($"X * Y = {numberA}");

            ContinueOrNot();
        }

        static void Dividing(int numberX, int numberY)
        {
            var numberA = (double)numberX / numberY;
            Console.WriteLine($"X / Y = {numberA}");

            ContinueOrNot();
        }

        static void Rising(int numberX, int numberY)
        {
            var numberA = Math.Pow(numberX, numberY);

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

        static void Factorial(int numberX, int numberY)
        {
            long factorialX = 1;
            for (int i = 1; i <= numberX; i++)
            {
                factorialX *= i;
            }

            long factorialY = 1;
            for (int x = 1; x <= numberY; x++)
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