using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Часть 2 Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, выполнить реализацию
//алгоритма с использованием операторов цикла do - while, обеспечить вывод полученных результатов. Использование других операторов
//цикла недопустимо.
//Задачи
//Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
//Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int z = Convert.ToInt32(Console.ReadLine());
            int p = 0;    // положительные
            int o = 0;    // отрицательные
            do
            {
                if (z > 0)
                {
                    p++;
                }
                else
                {
                    o++;
                }
                Console.WriteLine("Количество положительных чисел = {0}, отрицательных = {1}", p, o);
                Console.WriteLine("Введите новое число");
                z = Convert.ToInt32(Console.ReadLine());
            } while (z != 0);
            Console.WriteLine("Окончательный счет");
            Console.WriteLine("Количество чисел {0}, из них положительных чисел = {1}, отрицательных = {2}", (p+o), p, o);
            Console.ReadLine();

        }
    }
}
