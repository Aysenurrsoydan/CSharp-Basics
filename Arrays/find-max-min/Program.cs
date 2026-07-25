namespace find_max_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Please enter the index {i} value of the array: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"The biggest number is: {max}");

        }
    }
}
