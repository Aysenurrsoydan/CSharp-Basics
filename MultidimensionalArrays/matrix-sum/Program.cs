namespace matrix_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"numbers[{i},{j}] = ");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    total += numbers[i,j];
                }
            }
            Console.WriteLine(total);
        }
    }
}
