namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== NUMBER GUESSING GAME ===");
            Console.WriteLine("----------------------------------");


            int systemNumber = 73;
            Console.WriteLine("Welcome to the Number Guessing Game!");

            while (true)
            { 
                Console.Write("Please guess a number between 1 and 100: ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess >= 1 && userGuess <= 100)
                {
                    if (userGuess == systemNumber)
                    {
                        Console.WriteLine("Congratulations, you guessed it right!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's not correct. Please try again.");
                    }
                }
                else
                { 
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                }

            }

            Console.WriteLine("Thank you for playing the Number Guessing Game!");

        }
    }
}
