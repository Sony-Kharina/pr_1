using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteka
{
   
    class BookStateEventArgs : EventArgs
    {
        public string Name { get; }
        public string Author { get; }

        public bool Available { get; set; }

        public BookStateEventArgs(string name, string author, bool available)
        {
            Name = name;
            Author = author;
            Available = available;
        }
        public string Full_name
        {
            get
            {
                return Name + " " + Author + " " + Available;
            }
        }
        
       
   
    }


    class Handler_I
    {
        public void Message_1()
        {
            Console.WriteLine("Состав книг изменился");
        }
        public void Message_2()
        {
            Console.WriteLine("Состав книг изменился");
        }
        public void Message_3()
        {
            Console.WriteLine("Запрошена несуществующая/недоступная книга");
        }
        public void Message_4()
        {
            Console.WriteLine("Вернули книгу, не принадлежащую библиотеке");
        }
    }


    class ClassCounter
    {
        public delegate void BookStateChanged();
        public delegate void UnknowBookOccured();
        public event BookStateChanged BookTook; // книга получена 
        public event BookStateChanged BookReturned; // книга возвращена 
        public event UnknowBookOccured UnknownBookRequested; // запрошена неизвестная книга 
        public event UnknowBookOccured UnknownBookReturned; // возврат неизвестной книги 
        public void Count(List<BookStateEventArgs> books)
        {
            
            Console.WriteLine("Список книг: ");
            foreach (var book in books)
            {
                Console.WriteLine(book.Full_name);
            }
            Console.WriteLine("Если хотите принести книгу, введите 1. Если хотите взять книгу, введите 2: ");
            int q = int.Parse(Console.ReadLine());

            if (q == 1)
            {
                Console.Write("Автор: ");
                string x = Console.ReadLine();
                Console.Write("Название: ");
                string y = Console.ReadLine();
                foreach (var book in books)
                {
                    if (x.Equals(book.Name) & y.Equals(book.Author) & book.Available == true)
                    {

                        books.Add(new BookStateEventArgs(x, y, true));
                        break;
                    }
                    else if (x.Equals(book.Name) & y.Equals(book.Author) & book.Available == false)
                    {
                        book.Available = true;
                        break;
                    }
                    else
                    {
                        UnknownBookReturned();
                        books.Add(new BookStateEventArgs(x, y, true));
                        break;
                    }
                }
                BookReturned();

            }
            if (q == 2)
            {

                Console.Write("Автор: ");
                string x = Console.ReadLine();
                Console.Write("Название: ");
                string y = Console.ReadLine();
                foreach (var book in books)
                {
                    if (x.Equals(book.Name) & y.Equals(book.Author))
                    {

                        book.Available = false;
                        BookTook();
                        break;
                    }
                    else
                    {
                        UnknownBookRequested();
                        break;
                    }
                }
            }
            Console.WriteLine("Список книг после изменения: ");
            foreach (var book in books)
            {
                Console.WriteLine(book.Full_name);
            }
        }
     }



    internal class Biblio
    {
        static void Main(string[] args)
        {
            List<BookStateEventArgs> books = new List<BookStateEventArgs>();
            string[] mas = new string[6];
            mas[0] = "Cassandra Clare";
            mas[1] = "The Mortal Instruments";
            mas[2] = "Alexander Romanovich Belyaev";
            mas[3] = "Professor Dowell's Head";
            mas[4] = "Mikhail Afanasyevich Bulgakov";
            mas[5] = "The Master and Margarita";

            for (int i = 0; i < mas.Length; i += 2)
            {
                books.Add(new BookStateEventArgs(mas[i], mas[i + 1], true));
            }



            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();

            Counter.BookTook += Handler1.Message_1;
            Counter.BookReturned += Handler1.Message_2;
            Counter.UnknownBookRequested += Handler1.Message_3;
            Counter.UnknownBookReturned += Handler1.Message_4;
            Console.Write("Нажмите любую клавишу, чтобы начать: ");
            while (int.Parse(Console.ReadLine()) != 0)
            {
                Counter.Count(List <BookStateEventArgs> books);
                Console.Write("Хотите закончить, наберите 0: ");
               

            }
        }
    }
}
