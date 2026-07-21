namespace break_continue_exercise
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamTutar = 0;
            Console.WriteLine("===== MENÜ =====");
            
            while (true)
            {
                Console.WriteLine("1-pizza:250 TL");
                Console.WriteLine("2-hamburger:150 TL");
                Console.WriteLine("3-makarna:100 TL");
                Console.WriteLine("4-hesabı göster");
                Console.WriteLine("5-çıkış");
                Console.WriteLine("Lütfen bir seçim yapınız (1-5):");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("kaç adet pizza istiyorsunuz?");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    toplamTutar += 250 * adet;
                    Console.WriteLine(adet + " adet pizza eklendi");
                }
                else if (secim == 2)
                {
                    Console.WriteLine("kaç adet hamburger istiyorsunuz?");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    toplamTutar += 150 * adet;
                    Console.WriteLine(adet + " adet hamburger eklendi");
                }
                else if (secim == 3)
                {
                    Console.WriteLine("kaç adet makarna istiyorsunuz?");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    toplamTutar += 100 * adet;
                    Console.WriteLine(adet + " adet makarna eklendi");

                }
                else if (secim == 4)
                {
                    Console.WriteLine("Toplam tutar: " + toplamTutar + " TL");
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    continue;
                }
            }


















        }
    }
}
