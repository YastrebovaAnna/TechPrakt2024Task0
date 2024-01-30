class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.Write("Enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out double number2))
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            else
                Console.WriteLine("Incorrect second number format.");
        }
        else
            Console.WriteLine("First number format is incorrect.");
    }
}
