namespace _260129_2_for_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tek for ile 50-5000 arasındaki 11 ve 13 ün katları sayısı ve katları toplamlarını ayrı ayrı gösteriniz.

            int toplam11 = 0;
            int sayiAdeti11 = 0;
            int toplam13 = 0;
            int sayiAdeti13 = 0;
            for (int i = 50; i < 5000; i++)
            {
                if (i%11==0)
                {
                    Console.WriteLine(i);
                    toplam11=toplam11 + i;
                    sayiAdeti11++;
                }
                if (i%13==0)
                {
                    Console.WriteLine(i);
                    toplam13 = toplam13 + i;
                    sayiAdeti13++;
                }
            }
            Console.WriteLine("11 için sayı adeti:" + sayiAdeti11);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("13 için sayı adeti:" + sayiAdeti13);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Sayıların katları toplamı:" + toplam11);
            Console.WriteLine("Sayıların katları toplamı:" + toplam13);
            

      
        }
    }
}
