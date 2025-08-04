using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kullanıcıdan alınan bilgi alıp ekrana yazdır
            string customerName, customerSurname, customerCity;
            int customerBirthYear;
            Console.WriteLine("Hedef Şehir");
            Console.WriteLine("----------------------");
            Console.Write("Adınız: ");
            customerName= Console.ReadLine();
            //Console.WriteLine("");
            Console.Write("Soyadınız: ");
            customerSurname= Console.ReadLine();
            Console.Write("Şehriniz: ");
            customerCity= Console.ReadLine();
            Console.Write("Doğum yılınız: ");
            customerBirthYear=int.Parse(Console.ReadLine());
            int todayAge=2025-customerBirthYear;
            #region süsleme
            customerName=customerName.Trim().ToUpper();
            customerSurname=customerSurname.Trim();
            customerCity=customerCity.Trim().ToUpper();
            #endregion
            Console.WriteLine("--------------------Sonuç Ekranı--------------------");
            //Console.WriteLine("Merhaba "+ customerName +" "+customerSurname+'!');
            Console.WriteLine($"Merhaba {customerName} {customerSurname}!");
            Console.WriteLine("2025 yılında, "+customerCity+" şehrinde, " + todayAge + " yaşında olacaksın.");
            Console.Read();
            #endregion

        }
    }
}
