namespace even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }
    }
}
