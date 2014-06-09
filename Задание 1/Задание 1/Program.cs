using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишите программу-модель анализа пожарного датчика в помещении, 
 * которая выводит сообщение «Пожарная ситуация», 
 * если температура (ее значение вводится с клавиатуры) в комнате превысила 60ºС.*/

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            Console.Write("Введите температуру:");
            temperature = int.Parse(Console.ReadLine());
            if (temperature > 60) Console.Write("Пожарная ситуация!");
            Console.ReadKey();
        }
    }
}
