namespace while_loop_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sayi = 1;
            int toplam = 0;

            while (sayi != 0)
            {
                Console.WriteLine("Please enter a number: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi != 0)
                {
                    toplam += sayi;
                }
            }
            
            Console.WriteLine("toplam: " + toplam);




        }
    }
}
