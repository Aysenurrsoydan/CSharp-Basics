namespace array_avarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int Average = 0;
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Please enter the index {i} value of the array: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*****************************");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }
            Console.WriteLine("*****************************");

            Average = total / numbers.Length;
            Console.WriteLine($"The average is: {Average}");

            
        }
    }
}
