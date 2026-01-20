namespace _260120_5_if_elseif_else_Tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            START:
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >= 0 && sayi <= 9)
            {
                Console.WriteLine("Sayı tek basamaklı");
            }
            else if (sayi>=10 && sayi <=99)
            {
                Console.WriteLine("Sayı 2 basamaklı");
            }
            else if (sayi >= 100 && sayi <= 999)
            {
                Console.WriteLine("Sayı 3 basamaklı");
            }
            else if (sayi >= 1000 && sayi <= 9999)
            {
                Console.WriteLine("Sayı 4 basamaklı");
            }
            else if (sayi >= 10000 && sayi <= 99999)
            {
                Console.WriteLine("Sayı 5 basamaklı");
            }
            else if (sayi >= 100000 && sayi <= 999999)
            {
                Console.WriteLine("Sayı 6 basamaklı");
            }
            else
            {
                Console.WriteLine("Artık yeter");
            }
            goto START;

        }
    }
}
