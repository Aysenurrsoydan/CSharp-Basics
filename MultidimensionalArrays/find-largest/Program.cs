namespace find_largest
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

            int max = numbers[0,0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
