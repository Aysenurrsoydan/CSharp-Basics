namespace digit_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
