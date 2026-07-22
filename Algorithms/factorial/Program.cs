namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of " + number + " is: " + factorial);



        }
    }
}
