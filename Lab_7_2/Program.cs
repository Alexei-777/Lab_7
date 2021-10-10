using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

namespace Lab_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Int32.Parse(Console.ReadLine());
            double Q =0;
            double P = 0;
            Kub(out Q, out P, a);
            Console.WriteLine($"Обьем куба: {Q} куб.м");
            Console.WriteLine($"Площадь поверхности: {P} кв.м");
            Console.ReadKey();
        }
        static void Kub(out double Q,out double P,int a) 
        { 
            Q= Math.Pow(a, 3);
            P= Math.Pow(a, 2) * 6;
        }
        
        static void Kub2(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Обьем куба: {Math.Pow(a, 3)} куб.м");
            Console.WriteLine($"Площадь поверхности: {Math.Pow(a, 2) * 6} кв.м");
            Console.ReadKey();
        }
            

    }

}