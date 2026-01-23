namespace _260123_1_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Switch case karar yapısı sadece eşitlik durumunda çalışan bir karar yapısıdır.
             */

            int sayi = 0;

            switch (sayi) // Değişken sadece tanımlanır. Burada tanımlanan değişken herhangi bir karşılaştırma operatörü ile kullanılmaz. Sadece case ler için hangi değişken kullanılacak olduğunu belirtir.
            {
                case 1: // sayi değişkeni 1'e eşit olduğunda buradaki kodlar okunur.

                    // Kod alanı
                    break; // 1 için son
                case 2:

                    break; // Her bir case bir break ile sonlanır.

                default: // Bir değer almaz. Eğer case lerde verilen değer sayi değişkeninde yoksa default kısmındaki kodlar okunacaktır. if-else yapısındaki else gibi çalışır.

                    // Kodlar
                    break; // default için son

                case 56:
                    // 56 için kodlar
                    break;
            }

            string metin = "merhaba";

            switch (metin)
            {
                default:
                    break;

                case "hello":
                case "mer":
                case "":
                    // Birden fazla case 1 adet break ile sonlandırılabilir.
                    break;

                case "slaw":
                    break;

                case "hallo":
                    break;
            }
        }
    }
}
