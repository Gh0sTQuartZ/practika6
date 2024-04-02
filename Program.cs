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
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = func2(x);
            Console.WriteLine("Результат функции: " + res);
            Console.ReadLine();
        }

        public static double func2(double x)
        {
            return Math.Cos(2 * x);
        }
    }
}
