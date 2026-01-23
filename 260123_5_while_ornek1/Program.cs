namespace _260123_5_while_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5-135 arasındaki sayıları ekrana yazınız.

            int sayi = 5;
            while (sayi < 135)
            {
                Console.WriteLine(sayi+",");
                sayi++;
            }

            // 5-135 arasındaki sayıların toplamını hesaplatınız.
            int toplam = 0;
            int sayi1 = 5;
            while (sayi1 < 135)
            {
                // toplam = toplam + sayi;
                toplam += sayi;
                Console.WriteLine(sayi1 + ",");
                sayi1++;
            }
            Console.WriteLine("5-135 arasındaki sayıların toplamı");
        }
    }
}
