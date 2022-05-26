using System;

namespace Discriminant
{
    internal class Discriminant
    {   
        static void Main(string[] args)
        {
            Console.Write("Коэффициент а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Коэффициент b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Коэффициент c: ");
            int c = int.Parse(Console.ReadLine());

            bool TryCalculate(int a, int b, int c, out double d)
            {
               
                d = b * b - 4 * a * c;
                if (d >= 0)
                {
                    Console.WriteLine(d);
                    return true;
                }
                else
                { 
                    return false; 
                }
            }
            bool q= TryCalculate(a, b, c, out double d);
            
            Console.Write(q);
            
        }
    }
}
