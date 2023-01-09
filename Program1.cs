using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanıcıad = string.Empty;

            string kullanıcısoyad = string.Empty;

            decimal not1 = 0;
            decimal not2 = 0;
            decimal not3 = 0;
            

            Console.Write("lütfen adınızı giriniz :");
            kullanıcıad = Console.ReadLine();

            Console.Write("Lütfen soyadınızı giriniz :");
            kullanıcısoyad = Console.ReadLine();
            
            Console.Write("{0} 1.Notunu gir :",kullanıcıad);
            not1 = decimal.Parse(Console.ReadLine());

            Console.Write("{0} 2.Notunu gir :", kullanıcıad);
            not2 = decimal.Parse(Console.ReadLine());

            Console.Write("{0} 3.Notunu gir :", kullanıcıad);
            not3 = decimal.Parse(Console.ReadLine());
            Console.Clear();
                
            öğrenci ögrencideger = new öğrenci();

            ögrencideger.öğrencideğerler(kullanıcıad, kullanıcısoyad, not1, not2, not3);
            

            Console.ReadLine();

        }
    }
}
