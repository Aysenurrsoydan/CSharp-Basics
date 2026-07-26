namespace string_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use of lenght

            Console.Write("Please enter a text: ");
            string text = Console.ReadLine();
            Console.WriteLine(text.Length);

            // Use of ToUpper()
            
            Console.WriteLine(text.ToUpper());

            // Use of ToLower()

            Console.WriteLine(text.ToLower());

            // Use of Trim()

            Console.WriteLine(text.Trim());

            // Use of Constains()

            if (text.Contains("a"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            if (text.Contains("*"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // Use of StartsWith()

            Console.WriteLine(text.StartsWith("a"));

            // Use of EndsWith()
            
            Console.WriteLine(text.EndsWith("*"));

            //Replace()

            Console.WriteLine(text.Replace("a", "*"));

            // Substring()

            Console.WriteLine(text.Substring(0,3));

            // Split()

            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

























        }
    }
}
