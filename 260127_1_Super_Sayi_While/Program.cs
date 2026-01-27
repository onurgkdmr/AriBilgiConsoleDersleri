namespace _260127_1_Super_Sayi_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kendisi hariç bölünenlerin toplamı kendisini veren sayılara süper sayı denir. 1-100000 arasındaki süper sayıları listeleyiniz.

            int sayi = 0;
            while (sayi<100000)
            {
                int bolenSayi = 1;
                int toplam = 0;
                while (sayi>bolenSayi)
                {
                    if (sayi%bolenSayi==0)
                    {
                        toplam = toplam + bolenSayi;
                    }
                    bolenSayi++;
                }
                if ( sayi==toplam)
                {
                    Console.WriteLine("Süper Sayı:"+sayi);
                }
                sayi++;
            }
        }
    }
}
