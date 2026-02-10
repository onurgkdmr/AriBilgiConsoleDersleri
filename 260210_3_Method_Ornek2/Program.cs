namespace _260210_3_Method_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan 3 sayıyı küçükten büyüğe doğru sıralamasını yapan işlemi kodlayınız.



            int sayi1 = SayiAl();
            int sayi2 = SayiAl();
            int sayi3 = SayiAl();
            Siralama(sayi1, sayi2, sayi3);//s1 en büyük
            Siralama(sayi2, sayi1, sayi3);//s2 en büyük
            Siralama(sayi3, sayi2, sayi1);//s3 en büyük

        }

        /// <summary>
        /// Kullanıcıdan sayı alır.
        /// </summary>
        /// <returns></returns>
        static int SayiAl()
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;

        }

        /// <summary>
        /// 3 sayı arasında sıralama yapar.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        static bool Siralama(int s1, int s2, int s3)
        {
            if (s1 > s2 && s1 > s3)
            {
                if (s2 > s3)
                {
                    Console.WriteLine("{0}>{1}>{2}",s1,s2,s3);
                }
                else if (s3 > s2)
                {
                    Console.WriteLine("{0}>{1}>{2}", s1, s3, s2);
                }
                return true;
            }
            return false;

        }
    }
}
