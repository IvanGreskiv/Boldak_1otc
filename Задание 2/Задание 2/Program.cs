using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Проверить истинность высказывания: 
 * "Данные числа x, y являются координатами точки, 
 * лежащей во второй координатной четверти". */

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите координаты X и Y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                if (y > 0)
                {
                    Console.Write("Данные числа {0}, {1} являются координатами точки, лежащей во второй части координатной плоскости.",x,y);
                }
            }
            else Console.Write("Данные числа {0}, {1} не являются координатами точки, лежащей во второй части координатной плоскости.",x,y);
            Console.ReadKey();
        }
    }
}
