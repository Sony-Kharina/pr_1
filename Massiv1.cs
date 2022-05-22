using System;

namespace Massiv_1
{
    internal class Massiv1
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Сколько строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();

            Console.WriteLine("Заполните двумерный массив: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Вы ввели массив: ");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Транспонированный массив: ");
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(mas[j, i]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

