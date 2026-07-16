using System.ComponentModel.Design;

namespace University_Admission_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== UNIVERSITY ENTRANCE SYSTEM ===");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your exam score: ");
            double examScore = double.Parse(Console.ReadLine());

            if (examScore < 300)
            {
                Console.WriteLine($"Dear {name}, you cannot make a choice yet.");
            }
            else if (examScore >= 300 && examScore < 400)  
            {
                Console.WriteLine($"Dear {name}, you can choose certain departments at some universities.");
            }
            else
            {
                Console.WriteLine($"Dear {name}, you can select any department you want.");
            }







        }
    }
}
