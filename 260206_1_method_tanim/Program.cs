namespace _260206_1_method_tanim
{
    internal class Program
    {
        static void Main(string[] args)
        { // Main method BAŞLAMA parantezi

            // string[] => string bir dizi. int[], double, ArrayList,... olabilir.
            // args => Değişken --> Parametre. Dizi, sayilar, isimler, sehirler olabilir.
            // Main(string[] args) => string bir dizi olan Main adında method (function) --> Topla, Fark, MaasZam, GetirKisiBilgileri
            // void => method türü --> int, double,... (var dışında bütün veri tipleri kullanılabilir.)
            // static => Erişim belirleyicisi. Bir yapıya (değişken, method, class) erişim yani kullanmak için izin olup olmadığını Erişim Belirleyicileri (internal, static, public, private, protected, protected internal) ile sağlarız.
            // Method nedir ? => Sürekl kodlanan bir kod varsa bu kodu sürekli kodlamak yerine onu bir format ile sürekli kullanabileceğimiz halde tutmak için Method içinde kodlarız ve her lazım olduğunda Method çağırmak yeterli olacaktır. Artık aynı kodu tekrar tekrar yazmaya gerek yoktur.
            
            // Aşağıdaki yapıyı method ile yapalım.

            Console.WriteLine("1. sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); // Bu bir method'dur.
            Toplam(sayi1, sayi2);

            // Bu 2 sayının büyükten küçük sayıyı çıkartan Fark adında method kodlayınız.
   
            Fark(sayi1, sayi2);

            // Büyük sayiya küçük sayının bölünmesiyle kalanı veren ModAl adında bir method kodlayınız.
           
            ModAl(sayi1, sayi2); // Method kullanımı

            // CTRL + M + O => Bütün methodları gizler.
            // CTRL + M + L => Gizli methodları gösterir.
            // CTRL + K + D => Hata yoksa düzenler. Hata varsa yapmaz.

            /*
             
             Erişim Belirleyicileri
            1-public => herkese açık
            2-private=> özel, sadece tanımlandığı yerde kullanılabilir
            3-internal=> aynı proje altında kullanılabilir
            4-protected=> kalıtım verdiği class larda kullanılabilir
            5-internal protected=> aynı proje altında ve kalıtım verdiği class larda kullanılabilir
            6-static=> tanımlama yapmadan direk kullanma imkanı sağlar.
             Class'lar konusunda Erişim Belirleyicileri ayrıntılı bir şekilde incelenecektir.

             Method Çeşitleri:
            1-Değer döndürmeyen void method
            2-Değer döndüren return method
            3-Aşiri yüklenmş Overload method

            */


        } // Main method BİTİŞ parantezi



        /// <summary>
        /// Büyük sayıdan küçük sayıyı çıkartır.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        static void Fark(int d1,int d2)
        {
            if (d1>d2)
            {
                int farkHesapla = d1 - d2;
                Console.WriteLine(farkHesapla);
            }
            else
            {
                int farkHesapla = d2 - d1;
                Console.WriteLine(farkHesapla);
            }
        }

        /// <summary>
        /// İki sayıyı toplar.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        static void Toplam(int s1,int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("2 sayının toplamı:" + toplam);
        }

        /// <summary>
        /// Büyük sayının küçük sayıya bölünmesiyle kalan sonucu verir.
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        static void ModAl(int b1,int b2)
        {
            if (b1>b2)
            {
                int modAlma = b1 % b2;
                Console.WriteLine(modAlma);
            }
            else
            {
                int modAlma = b1 % b2;
                Console.WriteLine(modAlma);
            }
        }
    }
}
