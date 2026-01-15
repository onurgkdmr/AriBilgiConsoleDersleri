namespace _260115_3_Mantiksal_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            3) Mantıksal Operatörler:

            and işareti (&&) => Ve anlamına gelir.
            or işareti (||) => Veya anlamına gelir.

            && => and (ve) için 2 işlem sorgusunda 4 değişik sorgu biçiminde çıkacak sonuçlar:

            True && True = True => and durumunda 2 koşul true olursa işlem sonucu true olur.
            True && False = False 
            False && True = False
            False && False = False

            || => or (veya) için 2 işlem sorgusunda 4 değişik sorgu biçiminde çıkacak sonuçlar:

            True || True = True 
            True || False = True 
            False || True = True 
            False || False = False => or durumunda 2 koşul false olursa işlem sonucu false olur. Diğer durumlarda hep true olur.
             */

            bool sonuc = 10 > 5 && 20 > 15;
            //----------True && True 
            //----------True
            Console.WriteLine("10 > 5 && 20 > 15 işlem sonucu:" + sonuc);
           
            sonuc = 10 > 5 && 0 >= 2;
            //----------True && False = False
            Console.WriteLine(" 10 > 5 && 0 >= 2 işlem sonucu:" + sonuc);
            
            sonuc = 10 > 5 || 0 >= 2;
            //--------True || False = True
            Console.WriteLine("10 > 5 || 0 >=2 işlem sonucu" + sonuc);



        }
    }
}
