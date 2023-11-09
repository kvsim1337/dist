using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Задание: Найти среднее арифметическое значение положительных чисел в двумерном массиве

namespace Mikheev_Kruglov_dist
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Запрашивание количества строк и столбцов:
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            // Создание двумерного массива:
            int[,] array = new int[rows, cols];

            // Заполнение двумерного массива рандомными числами:
            Random random = new Random();

            // Вывод заполненного массива на экран:
            Console.WriteLine("\nЗаполненный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Заполнение случайными числами от -100 до 100:
                    array[i, j] = random.Next(-100, 100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Подсчет суммы и количества положительных чисел в массиве:
            int sum = 0;
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                        count++;
                    }
                }
            }

            // Вычисление среднего арифметического значения:
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"\nСреднее арифметическое положительных чисел: {average}");
            }
            else
            {
                Console.WriteLine("В массиве нет положительных чисел!");
            }
            Console.ReadKey();
        }
    }
}