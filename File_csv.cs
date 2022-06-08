using System;
using System.Collections.Generic;
using System.IO;

namespace Sotrudniki
{enum Post {
        Директор,
        Сотрудник,
        Внешний_сотрудник,
    }
    class Sotrudnik
    {
        private int id { get; set; }
        private string name { get; set; }
        private Post post { get; set; }

        public Sotrudnik(int ID, string fio, Post post1)
        {
            id = ID;
            name = fio;
            post = post1;
        }
        public string Full_name
        {
            get { 
               return id + " " + name + " " + post ; 
           }
        }

    }
    internal class File_csv
    {
        static void Main(string[] args)
        {
            List<Sotrudnik> people = new List<Sotrudnik>();
            try
            {

                string[] lines = File.ReadAllLines("data-correct.csv");
                foreach (string s in lines)
                {

                    string[] q = s.Split(';');
                    bool success = int.TryParse(q[0], out var number);
                    if (success)
                    {
                        if (q[2].Equals("Директор"))
                        {
                            people.Add(new Sotrudnik(number, q[1], Post.Директор));
                        
                        }
                        else if (q[2].Equals("Сотрудник"))
                        {
                            people.Add(new Sotrudnik(number, q[1], Post.Сотрудник));
                         
                        }
                        else if (q[2].Equals("Внешний сотрудник"))
                        {
                            people.Add(new Sotrudnik(number, q[1], Post.Внешний_сотрудник));
                          
                        }
                        else
                        {
                            Console.WriteLine("Должность не из списка");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Неверный идентификатор");
                    }
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            foreach (var person in people)
            {
                Console.WriteLine(person.Full_name);
            }
        }
    }
}
