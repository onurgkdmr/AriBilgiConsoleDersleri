namespace _260123_3_ternary_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary operatörü => if else yerine kullanılan ?: operatörleridir.
            // Kullanıcıdan alınan bir sayı pozitif mi, negatif mi hesabını ternary ile yapalım.

            BASLA:
            Console.WriteLine("Sayı giriniz:");
            int sayi=int.Parse(Console.ReadLine());
            
            // sayi>0 ? "Pozitif" : "Negatif"
            // Koşul ? True : False // Ternary operatörü kullanımı
            // Koşul  ? Koşul doğru (True) ise yazılacak kod alanı : Koşul hatalı (False) ise yazılacak kod alanı


            if (sayi>0)
            {
                Console.WriteLine("Pozitif" + sayi);
            }
            else
            {
                Console.WriteLine("Negatif" + sayi);
            }
            
            Console.WriteLine("-------------- Ternary ile ---------------");
            string sonuc;
            // Console.WriteLine(sayi > 0 ? "Pozitif:" + sayi : "Negatif:" + sayi);
            sonuc = sayi > 0 ? "Pozitif" : "Negatif";
            goto BASLA;

        }
    }
}
