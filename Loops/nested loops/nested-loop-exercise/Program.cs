namespace nested_loop_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int t = 0; t < i; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


















        }
    }
}
