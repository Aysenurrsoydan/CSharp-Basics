namespace reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;

            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine("The reversed number is: " + reverse);
        }
    }
}
