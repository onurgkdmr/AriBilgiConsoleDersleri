namespace _260123_2_switch_case_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan kaçıncı ayda olduğu bilgisine göre ayın adı ve hangi mevsimde olduğunu hesaplayan yapıyı kodlayınız.


            Console.WriteLine("Kaçıncı aydasınız?");
            byte ay = Convert.ToByte(Console.ReadLine());

            switch (ay)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış mevsimi");
                    if (ay==1)
                    {
                        Console.WriteLine("Ocak ayı");
                    }
                    else if (ay==2)
                    {
                        Console.WriteLine("Şubat ayı");
                    }
                    else
                    {
                        Console.WriteLine("Aralık ayı");
                    }
                        break;
                //case 2:
                //    Console.WriteLine(  "2222222222");
                //    break;
                case 3:
                    Console.WriteLine("Mart-İlkbahar mevsimi");
                    break;
                case 4:
                    Console.WriteLine("Nisan-İlkbahar mevsimi");
                    break;
                case 5:
                    Console.WriteLine("Mayıs-İlkbahar mevsimi");
                    break;
                case 6:
                    Console.WriteLine("Haziran-Yaz mevsimi");
                    break;
                case 7:
                    Console.WriteLine("Temmuz-Yaz mevsimi");
                    break;
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz");
                    switch (ay)
                    {
                        case 6:
                            Console.WriteLine("Haziran ayındasınız");
                            break;
                        case 7:
                            Console.WriteLine("Temmuz ayındasınız");
                            break;
                        case 8:
                            Console.WriteLine("Ağustos ayındasınız");
                            break;
                        default:
                            // Bu çözümde default alanı okunmaz.
                            Console.WriteLine("---Bu alan okunmaz---");
                            break;
                    }
                    break;
                case 9:
                    Console.WriteLine("Eylül-Sonbahar mevsimi");
                    break;
                case 10:
                    Console.WriteLine("Ekim-Sonbahar mevsimi");
                    break;
                case 11:
                    Console.WriteLine("Kasım-Sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız, tekrar deneyiniz");
                    break;
            }
        }
    }
}
