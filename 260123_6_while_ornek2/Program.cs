namespace _260123_6_while_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) 1-100 arasındaki sayıları ekrana yazın ve toplamlarını hesaplayınız.
            2) 55-255 arasındaki 5 in katları olan sayıları ekrana yazdırın ve toplamlarını hesaplayınız.
            3) 500 den 0 a doğru 13 ün katları olan sayıları ekranda yazınız (tersten sayım olacak.).
            4) 1-10000 arasındaki asal sayıların toplamını hesaplayınız (zor soru).
            */

            /*
            1) 1-100 arasındaki sayıları ekrana yazın ve toplamlarını hesaplayınız.
            2) 55-255 arasındaki 5 in katları olan sayıları ekrana yazdırın ve toplamlarını hesaplayınız.
            3) 500 den 0 a doğru 13 ün katları olan sayıları ekranda yazınız (tersten sayım olacak.).
            4) 1-100 arasındaki asal sayıların toplamını hesaplayınız (zor soru).
            */

            // SORU-1:

            int toplam = 0;
            int sayi = 2;
            while (sayi < 100)
            {
                Console.WriteLine(sayi);
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine("1-100 arasındaki sayıların toplamı:" + toplam);

            // SORU-2:

            int sayi3 = 56;
            int toplam1 = 0;
            while (sayi3 < 255)
            {
                if (sayi3 % 5 == 0)
                {
                    Console.WriteLine(sayi3);
                    toplam1 += sayi3;
                }
                sayi3++;
            }
            Console.WriteLine("5-255 arasındaki 5'in katı olan sayıların toplamı:" + toplam1);

            // SORU-3:

            int sayi5 = 499;
            while (sayi5 > 0)
            {
                if (sayi5 % 13 == 0)
                {
                    Console.WriteLine(sayi5);
                }
                sayi5--;
            }

            Console.WriteLine("---------------------------------------------------");
            // SORU-4:

            int sayi2 = 2;
            // Bir sayının 1 ve kendisinden başka bölüneni yoksa asal demektir.
            int toplamAsalSayilar = 0;
            while (sayi2 < 10000)
            {
                // 1,2,3,......,10000
                // 1 asal değil, 2 asal sayıdır.
                // 3 => 2 (Yok) => 3 asal sayıdır.
                // 4=> 2 (Var) => 4 asal değildir.
                // 5=>2,3,4 (Bölünmez) => 5 asal sayıdır.
                // 6=>2,3,4,5 (2 ve 3 e bölünür) => 6 asal değildir.
                int bolenSayi = 2;
                bool asalMi = true;
                while (sayi2>bolenSayi)
                {
                    if (sayi2%bolenSayi==0)  // Eğer sayi2 bolenSayi ya tam bölünüyorsa sayi2 nin asal sayı olmadığını ispatlar.
                    {
                        asalMi = false;
                        break;  // İçinde bulunduğu döngüyü sonlandırır. sayi2 > bolenSayi koşulu döngüyü sonlandırır. Diğer döngüye devam eder.
                    }
                    bolenSayi++;
                }
                if (asalMi)
                {
                    toplamAsalSayilar = toplamAsalSayilar + sayi2;
                    Console.WriteLine(sayi2 + ",");
                }
                sayi2++;
            }
            Console.WriteLine();
            Console.WriteLine("Toplam Asal Sayılar:" + toplamAsalSayilar);
        }
    }
}
            