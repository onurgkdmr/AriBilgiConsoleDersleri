using System.Collections; // ArrayList için gerekli.


namespace _260203_2_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List, Collection, Array, Delegate

            // ArrayList kullanmak için using System.Collections; kütüphanesini en başa eklemeniz gereklidir.

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Arı Bilgi"); // ArrayList için eleman Add ile eklenr.
            arrayList.Add(45);
            arrayList.Add(25.5m); // decimal
            arrayList.Add(true);
            arrayList.Add(DateTime.Now);

            for (int i=0; i< arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            ArrayList sayilar = new ArrayList();

            sayilar.Add(87);
            sayilar.Add(23);
            sayilar.Add(54);
            sayilar.Add(5);
            sayilar.Add(4);
            sayilar.Add(1);

            sayilar.Sort(); // Küçükten büyüğe doğru sıralama yapar.

            for (int i=0; i<sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i] + "-");
            }

            Console.WriteLine();

            int kapasite = arrayList.Capacity; // Kapasite, 2'nin üssü şeklinde değer ile artar (2,4,8,16,32,...).
            
            Console.WriteLine("Kapasite, eleman sayısı değildir:" + kapasite);
            Console.WriteLine("Count ile eleman sayısı:" + arrayList.Count); // Count, ArrayList eleman sayısını verir.

            // index nedir?

            Console.WriteLine("Index No:" + arrayList.IndexOf("Arı Bilgi"));
            Console.WriteLine("Index No:" + arrayList.IndexOf(25.5m));
            Console.WriteLine("45 elemanı var mı:" + arrayList.Contains(45));

            if (arrayList.Contains(45))
            {
                Console.WriteLine("Index numarası:"+arrayList.IndexOf(45));
            }

            // ************************************************************************************

            // ArrayList kopyalamak => Devam edilecek.

        }
    }
}
