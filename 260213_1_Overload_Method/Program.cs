namespace _260213_1_Overload_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overload Method => Aşırı yüklenmiş method.
            // Aynı isimde birden fazla işlevi gören methodlara overload method (aşırı yüklenmiş method) denir.
            /*
            
             Aşırı yüklenmiş methodlar aşağıdaki kurallara göre yapılmalıdır:
            1) Aynı isimle olmalıdır.
            2) Farklı sayıda parametreye sahip olmalıdır. Eğer aynı sayıda parametre içeren başka overload method varsa parametre tiplerinden en az birinin farklı olması gereklidir.
            3) void ya da return olması overload özelliğini değiştirmez.

            */

            Console.WriteLine();
            Console.Write(true);
            Matematik("");
            
            int s1 = Matematik();
            int s2 = Matematik();
            Matematik(s1, s2);
            Console.WriteLine("2 sayının toplamı:"+ Matematik(s1,s2));

            double d1 = Matematik();
            double d2 = Matematik();
            Matematik(d1, d2);
            // Console.WriteLine("Küçük sayıdan büyük sayıya kadar olan sayıların toplamı:" + Matematik(d1, d2));
            Console.WriteLine("Küçük sayıdan büyük sayıya kadar olan sayıların toplamı:" + Matematik((double)s1, (double)s2));


        }

        /// <summary>
        /// Sayı girişi
        /// </summary>
        /// <returns></returns>
        static int Matematik()
        {
            Matematik("Sayı giriniz:");
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Ekrana girilen metni verir.
        /// </summary>
        /// <param name="metin"></param>
        static void Matematik(string metin) // Ekrana yazı yazar.
        {
            Console.WriteLine(metin);
        }


        /// <summary>
        /// test-1
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static void Matematik(int text)
        {
            // İsim aynı, parametre aynı ama parametre tipi diğerinden farklı. Overload method özelliği taşır.
        }

        /// <summary>
        /// test-2
        /// </summary>
        /// <param name="text"></param>
        static void Matematik(double text)
        {
            // İsim aynı, parametre aynı ama parametre tipi diğerinden farklı. Overload method özelliği taşır.
        }

        /// <summary>
        /// 2 sayının toplamını verir.
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        static int Matematik(int sayi1,int sayi2)
        {
            // İsim aynı, 2 parametre içerir ve 2 int tipinde parametre içeren aynı isimdeki methodlarda yok, overload özelliği taşır.
            return sayi1+ sayi2;
        }

        /// <summary>
        /// 2 sayı arasındaki sayıların toplamını hesaplar.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static double Matematik(double s1,double s2)
        {
            double toplam = 0;

            if (s1>s2)
            {
                for (double i = s2; i < s1; i++)
                {
                    toplam = toplam + i;
                }
            }
            else
            {
                for (double i = s1; i<s2; i++)
                {
                    toplam = toplam + i;
                }
            }
            return toplam;
        }

    }
}
