using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyankovaVV.Sprint4.Task3.V27.Lib;

namespace Tyuiu.PyankovaVV.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] {{ 4, 3, 5, 5, 3 },
                                         { 6, 7, 4, 4, 3 },
                                         { 3, 3, 7, 3, 6 },
                                         { 3, 4, 3, 7, 7 },
                                         { 3, 5, 6, 3, 6 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Пьянкова В. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Пьянкова Виктория Вячеславовна | АСОиУб-23-2                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7.                          *");
            Console.WriteLine("* Подсчитайте количество четных элементов во всем массиве.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Количество нулевых элементов = " + res);
            Console.ReadKey();
        }
    }
}
