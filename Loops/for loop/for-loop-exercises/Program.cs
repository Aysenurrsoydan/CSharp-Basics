namespace for_loop_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("--- Multiplication Table for " + number + " ---");

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine(i + " x " + number + " = " + result);
            }
        }
    }
}
