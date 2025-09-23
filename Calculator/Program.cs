namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {// Ask for the type of calculation
            string operationInput = AskOperation();

            int firstNumber, secondNumber;
            AskNumbers(out firstNumber, out secondNumber);

            int result;
            string symbol;

            RunOperation(operationInput, firstNumber, secondNumber, out result, out symbol);



            // Display the result and tell user the result
            PrintResult(firstNumber, secondNumber, result, symbol);
        }

        private static void PrintResult(int firstNumber, int secondNumber, int result, string symbol)
        {
            Console.WriteLine($"Answer is: {firstNumber} {symbol} {secondNumber} = " + result);
        }

        private static void RunOperation(string operationInput, int firstNumber, int secondNumber, out int result, out string symbol)
        {
            result = 0;
            symbol = "";
            if (operationInput == "1")
            {
                result = Add(firstNumber, secondNumber);
                symbol = "+";
            }
            else if (operationInput == "2")
            {
                result = Substract(firstNumber, secondNumber);
                symbol = "-";
            }
            else if (operationInput == "3")
            {
                result = Multiply(firstNumber, secondNumber);
                symbol = "*";
            }
            else if (operationInput == "4")
            {// Check for division by zero
                if (secondNumber == 0 || firstNumber == 0)
                {
                    Console.WriteLine("cant divide by zero, please try again.");
                }
                else
                {
                    result = Division(firstNumber, secondNumber);
                    symbol = "/";
                }
            }
        }

        private static int Division(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private static int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static void AskNumbers(out int firstNumber, out int secondNumber)
        {
            // Ask for the first number
            Console.WriteLine("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // Ask for the second number
            Console.WriteLine("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
        }

        private static string AskOperation()
        {
            Console.WriteLine("Choose Formula (1:sum, 2: minus,3: multiplication, 4: division): ");
            string operationInput = Console.ReadLine();
            return operationInput;
        }
    }
}
