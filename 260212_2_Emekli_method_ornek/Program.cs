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

            bu şartlara kişi emekli ise alacağı ikramiye, emekli değilse emekli olmama nedenini veren yapıyı kodlayınız
            
            NOT:Cinsiyet seçimi switch case ile yapılacaktır
            NOT:Eğer prim, yaş ve cinsiyet hatalı girilirse kullanıcıdan tekrar girilmesi istenecektir. Tekrar giriş yapmayacaksa bu koşul kullanıcıya bırakılır ve    kullanıcı klavyeden belirlenen bir harf,yazı,karakter ile çıkış sağlamalıdır.

            */





        }


        static string Cinsiyet()
        {
            Console.WriteLine("Cinsiyetinizi giriniz (Kadın/Erkek):");
            string cinsiyet = Console.ReadLine();
            return cinsiyet;
        }

        static byte Yas()
        {
            Console.WriteLine("Yaşınızı giriniz:");
            byte yas = Convert.ToByte(Console.ReadLine());
            return yas;
        }

        static int PrimGunSayisi()
        {
            Console.WriteLine("Prim gün sayısını giriniz:");
            int primGünSayisi = Convert.ToInt32(Console.ReadLine());
            return primGünSayisi;
        }

        static double Maas()
        {
            Console.WriteLine("Maaş bilgisini giriniz:");
            double maas = Convert.ToDouble(Console.ReadLine());
            return maas;
        }

        static double EmekliHesapla(string cinsiyet, byte yas, int primGunSayisi, double maas)
        {
            double ikramiye = 0;

            switch (cinsiyet)
            {
                case "Kadın":

                    yas = Yas();

                    if (yas >= 60)
                    {

                        primGunSayisi = PrimGunSayisi();

                        if (primGunSayisi >= 7300)
                        {
                            Console.WriteLine("Maaş bilgisini giriniz:");
                            maas = Convert.ToDouble(Console.ReadLine());
                            ikramiye = maas * 15;
                        }
                        else 
                            return ikramiye;
                    }
                    else
                    {
                        Console.WriteLine("");
                        return 0;
                    }

                    break;

                case "Erkek":
                    if (cinsiyet == "Erkek")
                    {
                        Console.WriteLine("Yaşınızı giriniz:");
                        yas = Convert.ToByte(Console.ReadLine());
                    }
                    return ikramiye;
                    break;

            }
            return ikramiye;
        }

    }
}
