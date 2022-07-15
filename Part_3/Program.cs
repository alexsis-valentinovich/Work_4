using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Часть 3 Задачи на использование операторов цикла с предусловием. Осуществить ввод необходимых данных, выполнить
//реализацию алгоритма с использованием операторов цикла while, обеспечить вывод полученных результатов. Использование
//других операторов цикла недопустимо.
//Задачи Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество
//квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции умножения
//и деления не использовать.
namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон прямоугольника");
            int a=Convert.ToInt32(Console.ReadLine()); //ширина или расстояние по Х
            int b=Convert.ToInt32(Console.ReadLine()); // высота или растояние по Y
            Console.WriteLine("Введите длины сторон квадрата");
            int c = Convert.ToInt32(Console.ReadLine()); // сторона квадрата
            int shirina = c;
            int vusota = c;
            int i = 0;
            while (vusota <= b)
            {
                while (shirina <= a)
                {
                    shirina += c;
                    i++;
                }
                vusota += c;
                shirina = c;
            }
            Console.WriteLine("Количество квадратов = {0}шт.", i);
            Console.ReadLine();
        }
    }
}
