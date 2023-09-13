namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("==========================");
        Console.Write("Please enter the operator (+, -, /, *): ");
        string operatorChoice = Console.ReadLine()!;
        Console.Write("How many numbers do you want to {0}?: ", operatorChoice);
        int numberChoice = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        for (int i = 1; i <= numberChoice; i++)
        {
            Console.Write("Please enter number {0}: ", i);
            double number = Convert.ToDouble(Console.ReadLine()); 
            if (i == 1)
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
