namespace HomeWorksOneselfOptional.OperationsWithFractionNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberX = new Number("NumberX", 13945, new ushort[] { 5, 8, 0, 5, 1 });

            var numberY = new Number("NumberY", 6345, new ushort[] { 7, 4, 3, 9, 0 });

            numberX.PrintNumber();

            numberY.PrintNumber();

            Addition(numberX, numberY);

            numberX.PrintNumber();

            numberY.PrintNumber();

            Subtraction(numberX, numberY);

            numberX.PrintNumber();

            numberY.PrintNumber();
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
    }
}