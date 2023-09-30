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
            //Console.WriteLine(C1(10));
            var param1 = int.Parse(Console.ReadLine());
            double res4 = Proc3_Amean(param1, 30);
            Console.WriteLine($"Среднее арифметическое: {res4}");
            var param2 = int.Parse(Console.ReadLine());
            double res5 = Proc4_Gmean(param1, 30);
            Console.WriteLine($"Среднее геометрическое: {res5}");
            Console.ReadKey();

        }


        //static тип результат или void ИмяФункции( список параметров вида тип_переменной ИмяПеременной, ...)
        //{
        //  тело метода
        // return значение, если тип результата не void
        //}

        static double Proc3_Amean(double X, double Y)
        {
            double amean = (X + Y) / 2;
            return amean;
        }
        static double Proc4_Gmean(double X, double Y)
        {
            double gmean = Math.Sqrt(X * Y);
            return gmean;
        }





        static string M1(int a)
        {
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
    
        static string M2(int a)
        {

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