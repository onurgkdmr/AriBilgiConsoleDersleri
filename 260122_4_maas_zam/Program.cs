namespace _260122_4_maas_zam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
        Kullanıcıdan alınan bir maaş için;
        Eğer maaş değeri 25.000 ve altında ise %45 zam
        Eğer maaş değeri 25.000-50.000 arasında ise %17 zam
        Eğer maaş değeri 50.000-100.000 arasında ise %9 zam
        Eğer maaş değeri 100.000-150.000 arasında ise %5 zam 
        Eğer maaş 150.000 üstünde ise %3 zam yapacak şekilde yapılan zam oranını ve yeni maaşı kullanıcıya gösteren yapıyı kodlayınız. (SORU DEĞİŞTİ)
         */

        BASLA:
            Console.WriteLine("Maaş bilgisi giriniz:");
            double maas = Convert.ToDouble(Console.ReadLine());

            if (maas > 0 && maas <= 25000)
            {
                double zam = maas * 45 / 100;
                double yenimaas = maas + zam;
                Console.WriteLine("Zam oranı:%45 ve yeni maaşı:" + yenimaas);
            }
            else if (maas >= 50000 && maas < 100000)
            {
                double zam = maas * 17 / 100;
                double yenimaas = maas + zam;
                Console.WriteLine("Zam oranı:%17 ve yeni maaşı:" + yenimaas);
            }
            else if (maas >= 100000 && maas < 150000)
            {
                double zam = maas * 9 / 100;
                double yenimaas = maas + zam;
                Console.WriteLine("Zam oranı:%9 ve yeni maaşı:" + yenimaas);
            }
            else if (maas >= 150000)
            {
                double zam = maas * 5 / 100;
                double yenimaas = maas + zam;
                Console.WriteLine("Zam oranı:%5 ve yeni maaşı:" + yenimaas);
            }
            goto BASLA;
        }
    }
}
