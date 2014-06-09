using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Дан номер месяца (1 — январь, 2 — февраль, ...). 
 * Вывести число дней в этом месяце для невисокосного года. */

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Введите число от 1 до 12:");
            x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: Console.Write("Январь,31"); break;
                case 2: Console.Write("Февраль,28"); break;
                case 3: Console.Write("Март,31"); break;
                case 4: Console.Write("Апрель,30"); break;
                case 5: Console.Write("Май,31"); break;
                case 6: Console.Write("Июнь,30"); break;
                case 7: Console.Write("Июль,31"); break;
                case 8: Console.Write("Август,31"); break;
                case 9: Console.Write("Сентябрь,30"); break;
                case 10: Console.Write("Октябрь,31"); break;
                case 11: Console.Write("Ноябрь,30"); break;
                case 12: Console.Write("Декабрь,31"); break;
            }
            Console.ReadKey();
        }
    }
}
