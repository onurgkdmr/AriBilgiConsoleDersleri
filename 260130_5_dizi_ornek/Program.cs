namespace _260130_5_dizi_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 11 sayı alınız. Girilen 11 sayıyı listelerken çift olan sayıların sağında ÇİFT, tek olan sayının sağında TEK yazısı yazdırın.

            int[] sayilar = new int[11];
            int elemanSayisi = sayilar.Length;

            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine(i + 1 + ". eleman:");
                //sayilar[i] = Convert.ToInt32(Console.ReadLine());  // uzun hali aşağıdaki gibidir:
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayi;
            }

            for (int i=0; i<elemanSayisi; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    Console.WriteLine(sayilar[i] + "-ÇİFT");
                }
                else
                {
                    Console.WriteLine(sayilar[i] + "-TEK");
                }
            }

            // Ternary ile çözümü aşağıdaki gibidir:

            // string yaz = sayilar[i] % 2 == 0 ? "-ÇİFT" : "-TEK";
            // Console.WriteLine(sayilar[i] + yaz);
        }
    }
}
