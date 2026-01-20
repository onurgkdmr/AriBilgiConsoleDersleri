namespace _260120_1_Tanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Karar yapıları ve koşul yapıları
            // if else, switch case, ternary operatör
            /*
            1- if else => eşitlik, karşılaştırma, oran...
               if else 
               if - else if - else
            2- Switch case => eşitlik durumu
            3- Ternary operatör => if else kısaltılmış hali 
            */

            if (true) // if içinte true yerine koşul yazılır (sayi==1, sayi>0, sayi<-10 vb.). Eğer bu koşul doğru ise if bloğundakii kodlar okunur.
            
            {
                // if blok kodları
            }

            else // else değilse anlamına gelir. Bu da if için false (Hayır-koşul false sonucunu verdi.) demektir. False olması durumunda else bloğundaki kodlar okunur.

            {
                // else blok kodları
            }

            Console.WriteLine("Sayı giriniz?");
            int sayi1=Convert.ToInt32(Console.ReadLine());

            if (sayi1>0) // evet, hayır karar yeri
                // buraya kod yazılmaz.
            {
                // evet ise bu alan okunacaktır.
                Console.WriteLine("Sayı 0 dan büyüktür");
            }
            // buraya kod yazılmaz.
            else // buraya kod yazılmaz, işaret koyulmaz.
            // buraya kod yazılmaz.
            {
                // hayır ise bu alan okunacaktır.
                Console.WriteLine("Sayı 0 dan küçüktür");
            }

        }
    }
}
