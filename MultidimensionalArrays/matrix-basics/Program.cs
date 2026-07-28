namespace matrix_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers =
            {
                {5,10,15},
                {20,25,30},
                {35,40,45},
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i,j]+" ");
                }
                Console.WriteLine();
            }














        }
    }
}
