namespace bigger_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            
            if (num1 == num2)
            {
                Console.Write("The numbers are equal.");
            }
            else if (num1 > num2)
            {
                Console.Write("The bigger number is: " + num1);
            }
            
            else
            {
                Console.Write("The bigger number is: " + num2);
            }
        }
    }
}
