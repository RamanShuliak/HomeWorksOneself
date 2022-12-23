namespace HomeWorksOneselfOptional.OperationsWithFractionNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This program take 2 signed fractional numbers and print the results" +
                $"of their addition, substraction and comparison{Environment.NewLine}");

            var numberX = new Number("NumberX", 13945, new ushort[] { 5, 8, 0, 5, 0 });

            var numberY = new Number("NumberY", 1394, new ushort[] { 6, 5, 4, 5, 7 });

            numberX.PrintNumber();

            numberY.PrintNumber();

            Addition(numberX, numberY);

            Subtraction(numberX, numberY);

            СomparisonOfNumbers(numberX, numberY);
        }

        static void Addition(Number firstNumber, Number secondNumber)
        {

            var integerPartResult = firstNumber.IntegerPart + secondNumber.IntegerPart;

            var fractionalPartResult = new ushort[firstNumber.FractionalPart.Length];

            var numberForAddition = 0;

            for (int i = firstNumber.FractionalPart.Length - 1; i >= 0; i--)
            {

                fractionalPartResult[i] = (ushort)(firstNumber.FractionalPart[i] + secondNumber.FractionalPart[i]
                    + numberForAddition);

                if (fractionalPartResult[i] >= 10)
                {
                    if (i == 0)
                    {
                        fractionalPartResult[i] %= 10;
                        integerPartResult += 1;
                    }
                    else
                    {
                        fractionalPartResult[i] %= 10;
                        numberForAddition = 1;
                    }
                }
                else
                {
                    numberForAddition = 0;
                }
            }
            var resultOfAddition = new Number("ResultOfAddition", integerPartResult, fractionalPartResult);

            resultOfAddition.PrintNumber();
        }

        static void Subtraction(Number firstNumber, Number secondNumber)
        {
            var integerPartResult = firstNumber.IntegerPart - secondNumber.IntegerPart;

            var fractionalPartResult = new ushort[firstNumber.FractionalPart.Length];

            for (var i = 0; i < firstNumber.FractionalPart.Length; i++)
            {
                if (firstNumber.FractionalPart[i] < secondNumber.FractionalPart[i])
                {
                    if(i == 0)
                    {
                        fractionalPartResult[0] = (ushort)(firstNumber.FractionalPart[0] - secondNumber.FractionalPart[0] + 10);
                        integerPartResult --;
                    }
                    else
                    {
                        fractionalPartResult[i] = (ushort)(firstNumber.FractionalPart[i] - secondNumber.FractionalPart[i] + 10);
                        if(fractionalPartResult[i - 1] == 0)
                        {
                            fractionalPartResult[i - 1] = 9;
                            fractionalPartResult[i - 2]--;
                        }
                        fractionalPartResult[i - 1] --;
                    }
                }
                else
                {
                    fractionalPartResult[i] = (ushort)(firstNumber.FractionalPart[i] - secondNumber.FractionalPart[i]);
                }
            }
            var resultOfSubstraction = new Number("ResultOfSubstraction", integerPartResult, fractionalPartResult);

            resultOfSubstraction.PrintNumber();

        }

        static void СomparisonOfNumbers(Number firstNumber, Number secondNumber)
        {
           if(firstNumber.IntegerPart > secondNumber.IntegerPart)
           {
               Console.WriteLine($"{firstNumber.Name} > {secondNumber.Name}");
           }
           else if (firstNumber.IntegerPart < secondNumber.IntegerPart)
           {
               Console.WriteLine($"{firstNumber.Name} < {secondNumber.Name}");
           }
           else
           {
              for(var i = 0; i < firstNumber.FractionalPart.Length; i++)
                {
                    if (firstNumber.FractionalPart[i] > secondNumber.FractionalPart[i])
                    {
                        Console.WriteLine($"{firstNumber.Name} > {secondNumber.Name}");
                        break;
                    }
                    else if(firstNumber.FractionalPart[i] < secondNumber.FractionalPart[i])
                    {
                        Console.WriteLine($"{firstNumber.Name} < {secondNumber.Name}");
                        break;
                    }
                    else if(firstNumber.FractionalPart[firstNumber.FractionalPart.Length-1] == secondNumber.FractionalPart[secondNumber.FractionalPart.Length - 1])
                    {
                        Console.WriteLine($"{firstNumber.Name} = {secondNumber.Name}");
                        break;
                    }
                } 
           }
        }
    }
}