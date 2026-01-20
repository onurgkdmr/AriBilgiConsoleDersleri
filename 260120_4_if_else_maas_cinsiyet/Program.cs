namespace _260120_4_if_else_maas_cinsiyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan cinsiyet ve maaş bilgisine göre;
            // Eğer cinsiyet kadın ise maaşına %20,5 zam, eğer cinsiyet erkek ise maaşına %21,25 zam yapılacak şekilde kodlayıp yeni zamlı maaşı ve
            // yapılan zam oranını da kullanıcıya gösterecek şekilde kodlayınız.

            DEST:
            Console.WriteLine("Cinsiyet bilgisi giriniz (K/E ya da kadın/erkek):");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Maaş miktarını giriniz:");
            double maas = double.Parse(Console.ReadLine());

            if (cinsiyet == "kadın" || cinsiyet == "k")
            {
                maas = maas + maas*20.5 / 100;
                Console.WriteLine("Zam oranı: %20.5 ile yeni maaşınız:" + maas);
            }
            else // Erkek
            {
                maas = maas + maas*21.25 / 100;
                Console.WriteLine("Zam oranı: %21.25 ile yeni maaşınız:" + maas);
            }

            Console.WriteLine("-----------------------");
            goto DEST;


        }
    }
}
