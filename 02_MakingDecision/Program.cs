using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if-else
            char symbol=' ';
            Console.Write("Notunuzu Giriniz:");
            bool isValid = int.TryParse(Console.ReadLine(),out int number);
            
            if (!isValid||number<0||number>100)
            {
                Console.WriteLine("Lütfen veri girişini düzgün yapın.");
            }
            else
            {
                if (number >= 90)
                {
                    symbol = 'A';
                }
                else if (number>=80  )
                {
                    symbol = 'B';
                }
                else if (number>=70  )
                {
                    symbol = 'C';
                }
                else if (number>=60  )
                {
                    symbol = 'D';
                }
                else
                {
                    symbol = 'F';
                }
                Console.WriteLine($"Harf notunuz: {symbol}");
                if (symbol != 'F')
                {
                    Console.WriteLine("Dersi Geçtiniz.");
                }
                else { Console.WriteLine("Kaldınız."); }
                #endregion
            }

            Console.ReadLine();
        }
    }
}
