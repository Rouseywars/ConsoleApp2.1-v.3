using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._1_v._3_
{
    class Program //Базовый уровень

    {
        static void Main(string[] args)
        {
            bool A = false;
            bool B = false;
            bool C = true;
            Console.WriteLine((!A || !B) && !C); //Task "а"
            Console.WriteLine((!A || !B) && (A || B)); //Task "б"
            Console.WriteLine((A && B || A && C || !C)); //Task "в"
            Console.ReadKey();
        }
    }
}
/*
{
    class Program //Средний уровень
    {
        static double s = 0.02, p = 0.10; //надбавка
        static double m = 5 & 6 & 7 & 8 & 9 & 10, n = 11 & 12 & 13 & 14 & 15 & 16 & 17 & 18 & 19 & 20; //стаж
        static void Main(string[] args)
        {
            try
                {
                Console.Write("Введите зарплату: ");
                double salary = double.Parse(Console.ReadLine());
                Console.Write("Введите стаж: ");
                double seniority = double.Parse(Console.ReadLine());
                if (seniority >= m)
                    salary += salary * s;
                else if (seniority >= n)
                    salary += salary * p;
                Console.WriteLine($"Зарплата с надбавкой составляет: {salary}");
                Console.ReadKey();
                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
*/