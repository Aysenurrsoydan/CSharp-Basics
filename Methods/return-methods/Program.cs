namespace return_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squareOfSixteen = Square(16);
            Console.WriteLine("The square of 16 is: " + squareOfSixteen);
        }

        static int Square(int number)
        {
            int result = number * number;
            return result;
        }
    }
}
