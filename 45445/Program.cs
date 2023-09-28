using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45445
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(M2());
        }

        static string M1()
        {
            Console.WriteLine("Введите количество рублей: ");
            string tmp = Console.ReadLine();
            int a = int.Parse(tmp);

            if (a < 0)
            {
                return "Денежная валюта не может быть отрицательной (пока что)";
            }
            else
            {
                if (a % 10 == 1 && a % 100 != 11)
                {
                    return $"{a} рубль";
                }
                else if ((a % 10 >= 2 && a % 10 <= 4) && (a % 100 < 10 || a % 100 >= 20))
                {
                    return $"{a} рубля";
                }
                else
                {
                    return $"{a} рублей";
                }
            }
        }
    
        static string M2()
        {
            Console.WriteLine("Введите трехзначное число");
            string tmp = Console.ReadLine();
            int a = int.Parse(tmp);

            if (100 > a || a > 999)
            {
                return "Число не является трехзначным";
            }
            else
            {
                int ff = a / 100;
                int gg = a % 10;

                if (ff == gg)
                {
                    return "Число является палиндромом";
                }
                else
                {
                    return "Число не является палиндромом";
                }
            }
        }

      

    }
}