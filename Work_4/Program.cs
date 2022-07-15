using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Часть 1 Задачи на использование операторов цикла for. Осуществить ввод необходимых данных, выполнить реализацию
//алгоритма с использованием операторов цикла for, обеспечить вывод полученных результатов. Не разрешается использовать
//другие операторы цикла.
//Задачи
//Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую
//формулу: N^2 = 1 + 3 + 5 + ... +(2 * N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы
//(в результате будут выведены квадраты всех целых чисел от 1 до N).
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, s);
            }
            Console.ReadLine();
        }
    }
}
