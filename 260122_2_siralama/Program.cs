namespace _260122_2_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           2-Kullanıcıdan alınan 3 sayı için, sayıları küçükten büyüğe doğru sıralayan yapıyı kodlayınız?
           */

            // SORU-2:
            Console.WriteLine("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2 && sayi1>sayi3)
            {
                if (sayi2>sayi3)
                {
                    Console.WriteLine("{0} > {1} > {2}",sayi1,sayi2,sayi3);
                }
                else if (sayi3>sayi2)
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi1, sayi3, sayi2);
                }
                else if (sayi2 == sayi3)
                {
                    Console.WriteLine("{0} > {1} = {2}", sayi1, sayi3, sayi2);

                }
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                if (sayi1>sayi3)
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi2, sayi1, sayi3);
                }
                else if (sayi3>sayi1)
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi2, sayi3, sayi1);
                }
                else if (sayi3==sayi1)
                {
                    Console.WriteLine("{0} > {1} = {2}", sayi2, sayi3, sayi1);
                }
            }
            else if (sayi3>sayi1 && sayi3> sayi2)
            {
                if (sayi1>sayi2)
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi3, sayi1, sayi2);
                }
                else if (sayi2>sayi1)
                {
                    Console.WriteLine("{0} > {1} > {2}", sayi3, sayi2, sayi1);
                }
                else if (sayi1==sayi2)
                {
                    Console.WriteLine("{0} > {1} = {2}", sayi3, sayi2, sayi1);
                }
            }
            else
            {
                Console.WriteLine("Bütün sayılar eşittir.");
            }
            
        }
    }
}
