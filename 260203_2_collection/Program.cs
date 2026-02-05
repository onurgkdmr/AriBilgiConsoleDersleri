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

            Console.WriteLine("----------ArrayList elemanları----------");
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
            Console.WriteLine("------------Array List Kopya devam------------------");

            // ************************************************************************************

            // ArrayList kopyalamak => Devam edilecek.

            ArrayList newArrayList = new ArrayList(arrayList);  // arrayList elemanlarını newArrayList içine kopyalar/atar.

            for (int i=0; i<newArrayList.Count; i++)
            {
                Console.WriteLine(newArrayList[i]);
            }

            Console.WriteLine("------ Yeni Kopya ArrayList ------");
            
            arrayList.Add("Clone işlemi");
            ArrayList newCopyList = (ArrayList)arrayList.Clone();  // ArrayList bu işlem ile newCopyList'e kopyalanır.
            
            // (ArrayList) işlemi class düzeyinde bir cast (tip dönüşümü) işlemidir.

            for (int i=0; i<newCopyList.Count; i++)
            {
                Console.WriteLine(newCopyList[i]);
            }

            // *************************************************************************************

            Console.WriteLine("------ Döngü ile Ekleme ------");

            ArrayList arrayListDongu = new ArrayList();

            for (int i=0; i < arrayList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". eleman type:" + arrayList[i].GetType());
                arrayListDongu.Add(arrayList[i]);
                Console.WriteLine(arrayListDongu[i]);
            }

            Console.WriteLine("------ Sayılar ArrayList ------");

            sayilar.Reverse();  // Elemanları index numarasına göre ters çevirir.

            for (int i=0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            // ArrayList için CopyTo işlemi:

            Console.WriteLine("------ CopyTo ile İşlem ------");

            string[] sehirler = new string[12];
            sehirler[0] = "İzmir";
            sehirler[1] = "Mardin";
            sehirler[2] = "Zonguldak";
            sehirler[3] = "Muğla";
            sehirler[4] = "Diyarbakır";
            sehirler[5] = "Iğdır";


            ArrayList city = new ArrayList();

            city.Add("Adana");
            city.Add("Isparta");
            city.Add("Kars");
            city.Add("Ankara");
            city.Add("Malatya");
            city.Add("Mersin");

            //city.CopyTo(cityIndex, kopyalanacak Collection/Dizi, üzerine yazılacak Index, başlangıç değeri);
            city.CopyTo(1, sehirler, 9, 1);  // 1 index City'de Isparta, sehirler 9. index'e taşı.
            city.CopyTo(4, sehirler, 11, 1);  // 4 index City'de Malatya, sehirler 11. index'e taşı.


            for (int i = 0; i < sehirler.Count(); i++)
            {
                Console.WriteLine(i + ".index:" + sehirler[i]);
            }

        }
    }
}
