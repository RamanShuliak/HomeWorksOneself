namespace HomeWorksOneself1.DaysNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterDayNumber();

            
        }
        static void EnterDayNumber()
        {
            Console.WriteLine("Please, enter the number of the day of week, or 0 if you want to close the program");

            var enteredNumber = Console.ReadLine();
            var dayNumber = 0;

            if (int.TryParse(enteredNumber, out dayNumber))
            {
                PrintNameOfDay(dayNumber);
            }
            else
            {
                Console.WriteLine($"You enter wrong data. Try again {Environment.NewLine}");
                EnterDayNumber();
            }
        }

        static void PrintNameOfDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine($"You select Monday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 2:
                    Console.WriteLine($"You select Tuesday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 3:
                    Console.WriteLine($"You select Wednesday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 4:
                    Console.WriteLine($"You select Thursday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 5:
                    Console.WriteLine($"You select Friday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 6:
                    Console.WriteLine($"You select Saturday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 7:
                    Console.WriteLine($"You select Sunday {Environment.NewLine}");
                    EnterDayNumber();
                    break;
                case 0:
                    Console.WriteLine("End the program");
                    break;
                default:
                    Console.WriteLine($"There are no days with such number {Environment.NewLine}");
                    EnterDayNumber();
                    break;
            }
        }
    }
}
