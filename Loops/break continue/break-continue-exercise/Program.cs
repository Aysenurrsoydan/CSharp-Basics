namespace break_continue_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalAmount = 0;
            Console.WriteLine("===== MENU =====");

            while (true)
            {
                Console.WriteLine("1-Pizza: 250 TL");
                Console.WriteLine("2-Burger: 150 TL");
                Console.WriteLine("3-Pasta: 100 TL");
                Console.WriteLine("4-Show Bill");
                Console.WriteLine("5-Exit");
                Console.WriteLine("Please make a choice (1-5):");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("How many pizzas would you like?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    totalAmount += 250 * quantity;
                    Console.WriteLine(quantity + " pizza(s) added");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("How many burgers would you like?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    totalAmount += 150 * quantity;
                    Console.WriteLine(quantity + " burger(s) added");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("How many orders of pasta would you like?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    totalAmount += 100 * quantity;
                    Console.WriteLine(quantity + " pasta(s) added");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Total amount: " + totalAmount + " TL");
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
            }
        }
    }
}