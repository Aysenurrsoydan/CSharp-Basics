namespace AGE_CALCULATOR_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== AGE CALCULATOR PROGRAM ===");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Please enter your birth year: ");
            int birtYear = int.Parse(Console.ReadLine());

            int age = 2026 - birtYear;
            Console.WriteLine("Your age: " + age);


        }
    }
}
