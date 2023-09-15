namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        PerformOneCalculation();       
    }
    private static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("==========================");
    }
    private static void PerformOneCalculation()
    {
        bool condition = true;   
        do
        {
            Console.Write("Please enter the operator (+, -, /, *) or return to exit: ");
            string operatorChoice = Console.ReadLine()!;
        
            if (operatorChoice == string.Empty)
            {
                condition = false;
            }
            else
            {
                Console.Write("How many numbers do you want to {0}?: ", operatorChoice);
                int numberChoice = Convert.ToInt32(Console.ReadLine());

                InputNumbers(operatorChoice, numberChoice);
            }
        
        } while (condition);
    } 
    private static void InputNumbers(string operatorChoice, int numberChoice)
    {
        double result = 0;
        
        for (int i = 1; i <= numberChoice; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            //double number = Convert.ToDouble(Console.ReadLine()); 
            string numString = Console.ReadLine()!;
            
            if (int.TryParse(numString, out int number))
            {
                
            } else
            {
                Console.WriteLine("That wasn't a valid number, please try again.");
                i--;
            }
            if (numberChoice == 1)
            {
                result = number;
            }  
            else
            {
                switch (operatorChoice)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*": 
                        result *= number;
                        break;
                    case "/":
                        result /= number;
                        break;
                    default:
                        Console.WriteLine("This is not a valid operator");
                        break;
                }
            }
            
        }
        
        Console.WriteLine("The answer is: {0}", result);
    }
}
