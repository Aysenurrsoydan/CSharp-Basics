namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}
