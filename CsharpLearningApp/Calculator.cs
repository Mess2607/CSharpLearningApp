namespace CsharpLearningApp
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string selection)
        {
            double result = double.NaN;

            switch (selection)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                    }
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "!":
                    result = Math.Sqrt(num1);
                    break;
                default: //check for invalid input                    
                    break;
            }
            return result;            
        }
    }
    public class Menu
    {
        public static void Calc()
        {
            bool endApp = false;

            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("--------------------");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //ask user for 2 numbers
                Console.Write("Input the first number followed by Enter:");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1)) //checking for invalid input
                {
                    Console.Write("This is not a valid input, dummy. Please enter a new value: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Input the second number followed by Enter:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2)) //checking for invalid input
                {
                    Console.Write("This is not a valid input, dummy. Please enter a new value: ");
                    numInput2 = Console.ReadLine();
                }

                //ask user to pick math operation
                Console.WriteLine("Available operations:");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t% : Modulo");
                Console.WriteLine("\t^ : Power");
                Console.WriteLine("\t! : Square root of the 1st number");
                Console.Write("Please choose an option followed by Enter:");

                string selection = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, selection);
                    if (double.IsNaN(result))
                    {
                        Console.Clear();
                        Console.WriteLine("Nope! The input was incorrect. Please start a new equation.");
                        continue;
                    }
                    else Console.WriteLine("Voila! Your result: " + result);                                        
                }

                catch (Exception error)
                {
                    Console.WriteLine("Whoops! Something went wrong! - Details: " + error.Message);
                }

                Console.WriteLine("Would you like to perform another operation? (press Y followed by Enter to continue): "); //check whether the user wants to continue
                if (Console.ReadLine().ToUpper() != "Y") endApp = true;
                else Console.Clear();
            }
                        
            Console.WriteLine("Okay then, bye!");
            return;
        }
    }
}

