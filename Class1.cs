using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class öğrenci

    {
        public void öğrencideğerler(string ad,string soyad,decimal not1,decimal not2,decimal not3 )
        {
            Console.WriteLine("Öğrencinin Bilgileri Aşşağıdaki gibidir");
            Console.WriteLine("Adı Soyadı:{0}{1}", ad, soyad);

            decimal ortalama = (not1 + not2 + not3) / 3;
            if(ortalama<45)
            {
                Console.WriteLine("Ortalamanız {0} barajı geçemediğiniz için sınıfta kaldınız", ortalama);
            }
           
            else if(ortalama>70)
            {
                Console.WriteLine("Ortalamanız {0} ve Teşekkür belgesi aldınız tebrikler", ortalama);

            }

            else if(ortalama>80)
            {
                Console.WriteLine("Ortalamanız {0} olduğu için taktir aldınız tebrikler ",ortalama);

            }

            else
            {
                Console.WriteLine("ortalamanız {0} olduğu için düz geçtiniz",ortalama);
            } 

        }









    }
}
