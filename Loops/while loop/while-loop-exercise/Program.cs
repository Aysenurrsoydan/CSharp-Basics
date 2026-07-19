namespace while_loop_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int password = 1234;
            Console.WriteLine("Please enter your password: ");
            int enteredPassword = int.Parse(Console.ReadLine());

            while (enteredPassword != password)
            {
                Console.WriteLine("Incorrect password, please try again: ");
                enteredPassword = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Correct password, login successful!");





        }
    }
}
