namespace _260213_2_Overload_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan 2 sayı için DortIslem() adında bir method kodlayınız.
            /*
            
            1) Bu 2 sayının toplamını DortIslem() adında method ile hesaplayınız. 
            2) Bu 2 sayının çarpımını DortIslem() adında method ile hesaplayınız. 
            3) Bu 2 sayının farkını DortIslem() adında method ile hesaplayınız. 
            4) Büyük sayının küçük sayıya bölümünde kalanı veren DortIslem() adında bir method kodlayınız.
            5) Büyük sayının küçük sayıya bölümünde bölümü veren DortIslem() adında bir method kodlayınız.

            */

            int s1 = DortIslem();
            int s2 = DortIslem();

            DortIslem("2 sayının toplamı:" + DortIslem(s1, s2));
            DortIslem("2 sayının çarpımı:" + DortIslem((long)s1, (long)s2));
            DortIslem("2 sayının farkı:" + DortIslem((short)s1, (short)s2));
            DortIslem("Büyük sayının küçük sayıya bölümünde kalan:" + DortIslem((double)s1, (double)s2));
            DortIslem("Büyük sayının küçük sayıya bölüm sonucu:" + DortIslem((decimal)s1, (decimal)s2));
            
        }

        static int DortIslem()
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }

        static int DortIslem(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static long DortIslem(long sayi1,long sayi2)
        {
            long carpim = sayi1 * sayi2;
            return carpim;
        }
        static long DortIslem(short sayi1,short sayi2)
        {
            long fark = sayi1 - sayi2;
            return fark;
        }
        
        static double DortIslem(double deger1,double deger2)
        {
            if (deger1>deger2)
            {
                return deger1 % deger2;
            }
            else
            {
                return deger2 % deger1;
            }
        }

        static decimal DortIslem(decimal deger1,decimal deger2)
        {
            if (deger1>deger2)
            {
                return deger1 / deger2;
            }
            else
            {
                return deger2 / deger1;
            }
        }

        static void DortIslem(string metin)
        {
            Console.WriteLine(metin);
        }



    }
}
