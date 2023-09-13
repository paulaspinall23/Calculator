namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator!");
        Console.WriteLine("==========================");
        Console.Write("Please enter the operator (+, -, /, *): ");
        string choice = Console.ReadLine()!;
        Console.Write("Please enter the first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
            case "*": 
                result = firstNumber * secondNumber;
                break;
            case "/":
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("This is not a valid operator");
                break;
        }
        Console.WriteLine("The answer is: {0}", result);

    }
}
