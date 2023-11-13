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
        static void Main(string[] args)
        {
            // Запрашивание количества строк и столбцов:
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            // Создание и заполнение двумерного массива:
            int[,] array = RandomFilling(rows, cols);

            // Вывод заполненного массива на экран:
            PrinterArray(array);

            // Вычисление и вывод среднего арифметического положительных чисел:
            Console.WriteLine($"\nСреднее арифметическое положительных чисел: {CalcArithmetic(array)}");

            Console.ReadKey();
        }

        // Метод заполнения рандомными числами:
        static int[,] RandomFilling(int rows, int cols)
        {
            int[,] array = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Заполнение случайными числами от -100 до 100:
                    array[i, j] = random.Next(-100, 100);
                }
            }
            return array;
        }

        // Метод печати:
        static void PrinterArray(int[,] array)
        {
            Console.WriteLine("\nЗаполненный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Метод вычисления среднего арифметического положительных чисел:
        static double CalcArithmetic(int[,] array)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                        count++;
                    }
                }
            }
            return count > 0 ? (double)sum / count : -1;
        }
    }
}