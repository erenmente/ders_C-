using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            #region for döngüsü
            //for (i = 1; i <= 100; i++)
            //{
            //    string multiple =string.Empty;
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        multiple = "-> 3ün ve 5in katı";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        multiple = "-> 3ün katı";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        multiple = "-> 5in katı";
            //    }
            //    Console.WriteLine(i + multiple);
            //}
            //i = 1;
            #endregion
            #region while döngüsü
            //while (i <= 100)
            //{
            //    string multiple = string.Empty;
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        multiple = "-> 3ün ve 5in katı";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        multiple = "-> 3ün katı";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        multiple = "-> 5in katı";
            //    }
            //    Console.WriteLine(i + multiple);
            //    i++;
            //}
            #endregion
            #region kullanıcıdan veri alarak for döngüsü
            Console.Write("Lütfen aralığın başını belirleyin: ");
            bool isOnsetValid = int.TryParse(Console.ReadLine(), out int onset);
            Console.Write("Lütfen aralığın sonunu belirleyin: ");
            bool isTerminationValid = int.TryParse(Console.ReadLine(), out int termination);
            Console.Write("1.bölen: ");
            bool isDivisorValid = int.TryParse(Console.ReadLine(), out int divisor);
            Console.Write("2.bölen: ");
            bool isDivisor_2Valid = int.TryParse(Console.ReadLine(), out int divisor_2);
            if (!isOnsetValid || !isTerminationValid || !isDivisor_2Valid || !isDivisorValid)
            {
                Console.WriteLine("Lütfen düzgün bir veri girişi yapın");
                return;
            }
            else if (onset > termination)
            {
                Console.WriteLine("Başlangıç bitişten büyük olamaz");
                return;
            }
            else
            {
                int total1=0;
                int total2=0;
                int commonTotal = 0;
                int commonMultiple = 0;
                int divisorMultiple = 0;
                int divisor_2Multiple = 0;

                for (i = onset; i <= termination; i++)
                {
                    string multiple = string.Empty;
                    if (i % divisor == 0 && i % divisor_2 == 0)
                    {
                        multiple = $"{divisor} ve {divisor_2}'nin katı ";
                        commonMultiple++;
                        commonTotal += i;
                    }
                    else if (i % divisor == 0)
                    {
                        multiple = $"{divisor}'ın katı";
                        divisorMultiple++;
                        total1 += i;
                        
                    }
                    else if (i % divisor_2 == 0)
                    {
                        multiple = $"{divisor_2}'nin katı ";
                        divisor_2Multiple++;
                        total2+= i;
                    }
                    Console.WriteLine($"{i} {multiple}");
                }
                Console.WriteLine("------------İSTATİSTİK ÖZETİ------------");
                Console.WriteLine($"{divisor} ve {divisor_2}'nin ortak kat sayısı: {commonMultiple}");
                Console.WriteLine($"{divisor}'un kat sayısı: {divisorMultiple}");
                Console.WriteLine($"{divisor_2}'nin kat sayısı: {divisor_2Multiple}");
                Console.WriteLine($"ortak katların toplamı= {commonTotal}");
                Console.WriteLine($"{divisor}'un katlarının toplamı= {total1}");
                Console.WriteLine($"{divisor_2}'nin katlarının toplamı= {total2}");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
