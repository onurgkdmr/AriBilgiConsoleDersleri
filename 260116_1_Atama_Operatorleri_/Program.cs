namespace _260116_1_Atama_Operatorleri_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Atama Operatörleri:
            += (Topla ve eşitle)
            -= (Çıkart ve eşitle)
            *= (Çarp ve eşitle)
            /= (Böl ve eşitle)
            %= (Mod al ve eşitle)
            ++ (1 arttır)
            -- (1 azalt)
            +  (String olarak birleştir)
             */

            int sayi1 = 900;
            // Kodun içinde herhangi bir yerde sayi1 e yeni değer eklenmesi gerekiyor.

            // int yeniSayi1 = sayi1 + 10;  // Bunun yerine aşağıdaki atama işlemi yapılarak yeni değişken tanımlaması yapılmaz. sayi1 değişkeni yeni aldığı değer üzerinden işlem görür.
            // sayi1, yeniSayi1 olarak devam edecek.
            // sayi1 = sayi1 + 10;
            sayi1 += 10;

            // Kod ilerledi, sayi1 için yeni bir işlem gerekli oldu. Örneğin %20 artırılması istendi.
            // int yeniSayi2 = yeniSayi1 + yeniSayi1 * 20 / 100;
            // sayi1 artık yeniSayi2 olarak devam edecek.
            // sayi1 = sayi1 + sayi1 * 20 / 100;
            sayi1 += sayi1 * 20 / 100;

            // -------------------------------------------------------------------------------------------

            int sayi2 = 100;  // değerini 5 ile çarpalım.
            //sayi2 = sayi2 * 5;
            sayi2 *= 5;
            Console.WriteLine("sayi2=100 değerinin 5 ile çarpılmış hali:" + sayi2);

            int sayi3 = 450;
            // sayi3 değeri 9 a bölündüğünde çıkan sonucu atama operatörü ile yazalım.
            sayi3 /= 9;
            Console.WriteLine("450 sayısının 9 a bölünmesi:" + sayi3);

            int sayi4 = 845;
            // sayi4 değerinin 9 a bölünmesi sonucu kalanı atama operatörü ile hesaplayınız.
            sayi4 %= 9;
            Console.WriteLine("845 sayısının 9 a bölünmesi sonucu kalan:" + sayi4);


            /*
            ++
            --
            +
            operatörlerinin kullanılması
             */


            int deger1 = 10;
            deger1++;  // deger1 in değeri 1 arttırıldı.
            Console.WriteLine("deger1 = 10 değeri ++ ile arttırıldı:" + deger1);

            deger1 += 1; // deger1++ ile aynıdır.
            Console.WriteLine("deger1 = 10 +=1 ile arttırıldı:" + deger1);

            int deger2 = ++deger1;  // deger 1 in değeri 1 arttırılır ve deger2 ye atanır.
            Console.WriteLine("++deger1:" + deger2);

            // int deger3 = deger2++ + 10;  // ilk olarak deger2 değeri deger3 e eşitlenir. Sonra ++ işlemi deger2 ye uygulanır.
            int deger3 = deger2++ + 10;  // deger2 nin değeri 1 arttırılır ve 10 ile toplanarak deger3 e atanır. Değer artımı yapılarak eşitleme yapılır.
            Console.WriteLine("deger3 için:" + deger3);
        }
    }
}
