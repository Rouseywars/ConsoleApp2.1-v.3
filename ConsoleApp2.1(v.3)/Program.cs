using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._1_v._3_
/*
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
*/
{
    class Program //Средний уровень
    {
        static double s = 0.02d, p = 0.10d; //надбавка
        static void Main(string[] args)
        {
            try
                {
                Console.WriteLine ("Введите зарплату: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine ("Введите стаж: ");
                int seniority = int.Parse(Console.ReadLine());
                if (seniority > 10)
                {
                    salary += salary * p;
                }
                else
                {
                    salary += salary * s;
                }
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