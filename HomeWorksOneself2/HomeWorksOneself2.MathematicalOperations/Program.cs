namespace HomeWorksOneself2.MathematicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the console calculator.");

            SelectSourceOfNumbers();
        }

        static void SelectSourceOfNumbers()
        {
            Console.WriteLine("Select, do you wont to enter numbers " +
                              "for operations by yourself (enter 1 to console), " +
                              "or generate them randomly (enter 2 to console)?");

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

        static void GetNumbersByUserAndStartCalculator()
        {
            var numberX = EnterNumber();
            var numberY = EnterNumber();

        }

        static void GetNumbersByRandomAndStartCalculator()
        {
            var numberX = GetRandomNumber();
            var numberY = GetRandomNumber();

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
                Console.WriteLine("Entered data is wrong. Please, enter the integer. Try again.");
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



    }
}