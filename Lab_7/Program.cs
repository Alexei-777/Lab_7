using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
//Для решения задачи можно использовать формулу Герона , где x, y, z – стороны треугольника, p – полупериметр.

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[N];
            int[] y = new int[N];
            int[] z = new int[N];
            Vvod(ref N, out x, out y, out z);
            Ploshad(N, x, y, z);
            Console.ReadKey();
        }
        static void Vvod(ref int N, out int[] x, out int[] y, out int[] z)
        {
            x = new int[N];
            y = new int[N];
            z = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введите длинну стороны {i + 1} треугольника X ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите длинну стороны {i + 1} треугольника Y ");
                y[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите длинну стороны {i + 1} треугольника Z ");
                z[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Ploshad(int N, int[] x, int[] y, int[] z)
        {
            for (int i = 0; i < N; i++)
            {
                int P = (x[i] + y[i] + z[i]) / 2;
                double S = Math.Sqrt(P * (P - x[i]) * (P - y[i]) * (P - z[i]));
                Console.WriteLine($"Площадь треугольника {i + 1} равна {S.ToString("0.##")}");
            }
        }
    }
}
