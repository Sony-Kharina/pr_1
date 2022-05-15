using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0; string v = "0";
            Console.WriteLine("Здраствуйте\r");
            while (v != "c")
            {
                Console.WriteLine("Что Вы хотите сделать?:");
                Console.WriteLine("\ta - Сложение");
                Console.WriteLine("\tb - Умножение");
                Console.WriteLine("\tc - Выход");
                Console.Write("Выбор: ");
                v = Console.ReadLine();
                while (v != "a" & v != "b" & v != "c")
                {
                    Console.WriteLine("Недопустимое значение, попробуйте снова: ");
                    v = Console.ReadLine();
                }
                if (v != "c")
                {
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }

                switch (v)
                {
                    case "a":
                        Console.WriteLine($"Результат: {num1} + {num2} = " + (num1 + num2));
                        break;

                    case "b":
                        Console.WriteLine($"Результат: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "c":
                        Console.WriteLine("До свидания");
                        break;

                }
            }
        }
    }
}
