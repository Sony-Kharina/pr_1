using System;
using System.IO;

namespace File_csv_1
{
    internal class File_csv
    {
        static void Main(string[] args)
        {
            try
            {                
                    string[] lines = File.ReadAllLines("data-correct.csv");
                    foreach (string s in lines)
                    {
                      string[] q= s.Split(';');
                    
                      foreach (string i in q)
                         {
                            System.Console.Write("{0} ", i);
                         }
                       Console.WriteLine();
                    }

             }
           catch (Exception e)
               {
                Console.WriteLine(e.Message);
               }
        }
    }
}
