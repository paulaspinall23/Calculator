namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my calculator!");
        Console.Write("Enter your first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The result is: {0}", firstNumber * secondNumber);

    }
}
