namespace _260212_2_Emekli_method_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Bir ülkede emeklilik hesabı cinsiyet,yaş,prim gün sayısı(Çalıştığı gün sayısı) şartlarına göre hesaplanıp emekli edilmektedir 
            Eğer Cinsiyet kadın ise
            yaş 60 ve üstü ise, prim 7300 ise kişi maaşının 15 katı kadar ikramiye alarak emekli ediliyor

            Eğer Cinsiyet erkek ise
            yaş 65 ve üstü ise, prim 8500 ise kişi maaşının 17.5 katı kadar ikramiye alarak emekli ediliyor 

            bu şartlara kişi emekli ise alacağı ikramiye, emekli değilse emekli olmama nedenini veren yapıyı kodlayınız.
            
            NOT:Cinsiyet seçimi switch case ile yapılacaktır
            NOT:Eğer prim, yaş ve cinsiyet hatalı girilirse kullanıcıdan tekrar girilmesi istenecektir. Tekrar giriş yapmayacaksa bu koşul kullanıcıya bırakılır ve    kullanıcı klavyeden belirlenen bir harf,yazı,karakter ile çıkış sağlamalıdır.

            */


            /*
                while (true)
            {
                Console.WriteLine("Cinsiyetinizi giriniz (kadın/bayan veya erkek/bay):");
                cinsiyet = Console.ReadLine().ToLower();
                if (cinsiyet == "kadın" || cinsiyet == "bayan" || cinsiyet == "erkek" || cinsiyet == "bay")
                {
                    Console.WriteLine("Çıkmak için herhangi bir tuşa basınız.");
                    string cikis = Console.ReadLine();
                    Console.WriteLine("Çıkış yaptınız.");
                    break;
                }
                Console.WriteLine("Cinsiyet girişi yanlış, tekrar deneyiniz.");
            }
            */

            EmekliHesapla(Cinsiyet());

        }


        static string Cinsiyet()
        {
            string cinsiyet = Console.ReadLine();
            return cinsiyet;
        }

        static byte Yas()
        {
            EkranaYaz("Yaşınızı giriniz:");
            byte yas = Convert.ToByte(Oku());
            return yas;
        }

        static int PrimGunSayisi()
        {
            EkranaYaz("Prim gün sayısını giriniz:");
            int primGünSayisi = Convert.ToInt32(Oku());
            return primGünSayisi;
        }

        static double Maas()
        {
            EkranaYaz("Maaşınızı giriniz:");
            double maas = Convert.ToDouble(Oku());
            return maas;
        }

        static void EmekliHesapla(string cinsiyet)
        {
            switch (cinsiyet)
            {
                case "kadın":
                case "bayan":
                    byte girilenYasKadin = Yas();

                    if (girilenYasKadin >= 60)
                    {
                        int girilenPrim = PrimGunSayisi();

                        if (girilenPrim >= 7300)
                        {
                            // Emekli olabilir ve ikramiye hesabı için maaşı gereklidir. Maaşı kullanıcıdan isteyelim:
                            double girilenMaas = Maas();
                            double ikramiye = girilenMaas * 15;
                            Cizgi();
                            EkranaYaz("Emekli olabilirsiniz TEBRİKLER!");
                            Cizgi();
                            EkranaYaz("Alacağınız ikramiye:" + ikramiye);
                        }
                        else
                        {
                            EkranaYaz("Girilen prim yetersiz olduğundan emekli olamazsınız. Gerekli gün sayısı:"+(7300-girilenPrim));
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} için yaş:{1} emeklilik için yeterli değildir", cinsiyet, girilenYasKadin);
                    }
                    break;

                case "erkek":
                case "bay":
                    byte girilenYasErkek = Yas();
                    if (girilenYasErkek >= 65)
                    {
                        int girilenPrim = PrimGunSayisi();
                        if (girilenPrim >= 8500)
                        {
                            double girilenMaas=Maas();
                            double ikramiye = Maas() * 17.5;
                            Console.WriteLine("Emekli olabilirsiniz ve ikramiyeniz:" + ikramiye);
                        }
                        else
                        {
                            Console.WriteLine("Emekli olamazsınız.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} için yaş:{1} emeklilik için yeterli değildir", cinsiyet, girilenYasErkek);
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı cinsiyet girişi");
                    break;
            }
        }
        static void EkranaYaz(string metin)
        {
            Console.WriteLine(metin);
        }

        static string Oku()
        {
            return Console.ReadLine();
        }

        static void Cizgi()
        {
            EkranaYaz("-------------------------");
        }
    }
}
