namespace method_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting("Ayşenur");
            Greeting("Ali");
            Greeting("Şule");
            Greeting("Saliha");
            Greeting("Alperen");

        }

        static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
