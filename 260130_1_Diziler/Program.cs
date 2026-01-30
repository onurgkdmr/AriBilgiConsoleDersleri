namespace _260130_1_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diziler => Aynı veri tipinde birden fazla data tutan yapılara denir.

            int sayi1 = 0;
            int sayi2 = 90;
            int sayi3 = 50;
            int sayi4 = 45;

            // Yukarıdaki gibi birden fazla sayı lazım olduğunda sayıları bir diziye ekleyip kullanabiliriz.

            int[] sayilar = { 0, 90, 50, 45 };  // Rastgele eleman alan dizi
            int[] numbers = new int[4]; // Eleman sayısı belirtilerek oluşturulan dizi
            numbers[0] = 0;  // 0 index numbers[0] şeklinde tanımlanır ama 1. eleman olarak ifade edilir. Diziye eleman atamak için kullanılan yoldur.

            numbers[1] = 90; // 2. eleman ataması
            numbers[2] = 50; // 3. eleman ataması
            numbers[3] = 45; // 4. eleman ataması

            //Console.WriteLine("{0} {1}",sayi1,sayi2);

            Console.WriteLine("Dizinin 0. index'i yani 1. elemanı:" + numbers[0]);
            Console.WriteLine("Dizinin 1. index'i yani 2. elemanı:" + numbers[1]);
            Console.WriteLine("Dizinin 2. index'i yani 3. elemanı:" + numbers[2]);
            Console.WriteLine("Dizinin 3. index'i yani 4. elemanı:" + numbers[3]);

            string[] isimler = new string[172];
            int personalSayisi = 172;
            double[] maaslar = new double[personalSayisi];
            DateTime[] dogumTarihi = new DateTime[personalSayisi];

            Console.WriteLine("---------Diziyi for ile listelemek----------");

            for (int i=0; i<4; i++)  // i=> 0, 1, 2, 3
            {
                Console.WriteLine("Dizinin" + i + "index'i yani" + (i + 1) + ". elemanı:" + numbers[i]);
            }


        }
    }
}
