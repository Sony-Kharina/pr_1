using System;

namespace Massiv_
{
    internal class Massiv
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько столбцов: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Сколько строк: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine();
            string s = "0";
            Console.WriteLine("Заполните двумерный массив, вводя элементы строк через пробел: ");
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine($"Строка {i}: ");
                
                s = Console.ReadLine();
                string[] values = s.Split(' ');
              
                    for (int j = 0; j < x; j++)
                    {
                        int number;

                        bool success = int.TryParse(values[j], out number);
                        if (success)
                        {
                            mas[j, i] = number;
                        }
                    }
                }
                
                
            Console.WriteLine("Вы ввели массив: ");
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(mas[j, i]);
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("Транспонированный массив: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

