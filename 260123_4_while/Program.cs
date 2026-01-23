namespace _260123_4_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ardışık işlemleri koşula bağlı ya da koşulsuz yapmak için döngüler kullanılır.
            1- while
            2- do while
            3- for
            4- foreach
             */

            // Console.WriteLine("1);
            // Console.WriteLine("2);
            // Console.WriteLine("3);
            // Console.WriteLine("4);
            // Console.WriteLine("5);

            int sayi = 0;
            // while(true)
            while (sayi<10) // 0<10, 1<10, 2<10, 3<10, 4<10....., 9<10 => TRUE,   10<10 => FALSE (Döngü biter.)
            {
                // Döngü her true olduğunda bu alandaki kodlar okunacaktır.
                Console.WriteLine(sayi); // 0,1,2,3,4,5,6,7,8,9
                sayi++; // 0+1=1, 1+1=2, 2+1=3, 3+1=4, 4+1=5, 5+1=6, 6+1=7, 7+1=8, 8+1=9, 9+1=10
                // sayi bir sayaçtır döngü için. Burada sayaç sürekli artırma işlemi yapmıştır.
            }


        }
    }
}
