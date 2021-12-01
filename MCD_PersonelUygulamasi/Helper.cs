using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    public static class Helper
    {

        //Helper H1 = new Helper(); !!!Statik olarak işaretlenmiş classlar örneklenemez...

        /* public void Test()
         {
        Statik olan class lar içerisinde standart metotlar kullanılmaz.Static olmayan metotlar
         }
        */

        /* puclic string Tanim { get; set; }

         Statik olan class lar içerisiidne static olmayan field tanımları yapılamaz.*/

        /* puclic Helper ()
        {
        HEr nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır.
        */

        static Helper()
        {
            // Uygulama içerisinde istenildiğinde kadar çağrılsınlar sadece ilk çağrılmada çalışırlar ..
            Console.WriteLine("Helper => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres,string konu,string icerik)
        {
            ///Email gönderme işlemleri devam edecek 
            Console.WriteLine("Mail gönderim işlemi başarılı ");
        }
    }
}
