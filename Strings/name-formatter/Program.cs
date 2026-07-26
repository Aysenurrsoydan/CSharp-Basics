namespace name_formatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name and surname: ");
            string text = Console.ReadLine();

            string fullName = Console.ReadLine();

            string trimmedName = fullName.Trim();

            string lowerName = trimmedName.ToLower();

            string[] words = lowerName.Split(' ');

            string firstName = words[0].Substring(0, 1).ToUpper() + words[0].Substring(1);

            string lastName = words[1].Substring(0, 1).ToUpper() + words[1].Substring(1);

            Console.WriteLine(firstName + " " + lastName);

        }
    }
}
