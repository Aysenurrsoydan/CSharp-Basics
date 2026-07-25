namespace number_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Please enter the index {i} value of the array: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter another a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound) 
            {
                Console.WriteLine("This number is included in the array.");
            }
            else
            {
                Console.WriteLine("This number is not included in the array.");
            }
        }
    }
}
