namespace _260129_3_for_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-15000 arasındaki sayıların 5'in katı olup da 2'nin katı olmayan sayıların sayısı ve toplamlarını hesaplayınız.

            int toplam = 0;
            int sayiAdeti = 0;
            
            for(int i=1;i<15000;i++)
            {
                if(i%5==0 && !(i%2==0))
                {
                    sayiAdeti++;
                    toplam = toplam + i;
                }
            }
            Console.WriteLine("Sayı adeti:" + sayiAdeti);
            Console.WriteLine("Sayıların toplamı:" + toplam);
        }
    }
}
