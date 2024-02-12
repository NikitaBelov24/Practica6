using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine()); // Считываем число с клавиатуры

            double result = Math.Sin(x) + Math.Cos(x); // Вычисляем Sin(x) + Cos(x)

            Console.Write("Результат вычислений: " + $"{result:F2}"); // Выводим результат на экран
            Console.ReadKey();
        }
    }
}
