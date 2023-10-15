namespace Swapping_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello , Welcome to my application");

            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine()!);

            int temp = 0;

            temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;

            Console.WriteLine("\nProgess is going...\n");

            Console.WriteLine($"FirstNumber is {firstNumber}");
            Console.WriteLine($"SecondNumber is {secondNumber}");
        }
    }
}