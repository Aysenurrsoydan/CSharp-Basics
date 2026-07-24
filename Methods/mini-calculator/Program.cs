namespace mini_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Addition(num1, num2);
            Subtraction(num1, num2);
            Multiplication(num1, num2);
            Division(num1, num2);
        }

        static void Addition(double num1, double num2)
        {
            Console.WriteLine("Sum of numbers: " + (num1 + num2));
        }

        static void Subtraction(double num1, double num2)
        {
            Console.WriteLine("Difference of numbers: " + (num1 - num2));
        }

        static void Multiplication(double num1, double num2)
        {
            Console.WriteLine("Multiplication of numbers: " + (num1 * num2));
        }

        static void Division(double num1, double num2)
        {
            Console.WriteLine("Division of numbers: " + (num1 / num2));
        }

















    }
}
