using System;

namespace Massiv_
{
    internal class Massiv
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько строк: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Сколько столбцов: ");
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            int[,] mas2 = new int[y, x];
            Console.WriteLine();
            string s = "0";
            Console.WriteLine("Заполните двумерный массив, вводя элементы строк через пробел: ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Строка {i}: ");
                string[] values = Console.ReadLine().Split();
  
              
                    for (int j = 0; j < y; j++)
                    {
                      
                        bool success = int.TryParse(values[j], out var number);
                        if (success)
                        {
                            mas[i, j] = number;
                            mas2[j, i] = number;
                        }
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
                    Console.Write(mas2[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

