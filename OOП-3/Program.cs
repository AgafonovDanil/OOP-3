using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOП_3
{
    class Book
    {
        private string author;

        private string nameBook;

        private int numberPages;

        private bool collection;




        public Book(string Author, bool Collection)
        {
            this.author = Author;

            this.collection = Collection;
        }


        public Book(string author, string nameBook, int numberPages, bool collection)
        {
            this.author = author;

            this.nameBook = nameBook;

            this.numberPages = numberPages;

            this.collection = collection;
        }
        public void WriteBook
            ()
        {
            Console.WriteLine("\nАвтор книги- " + author);

            Console.WriteLine("Название книги - " + nameBook);

            Console.WriteLine("Количество страниц в книге- " + numberPages);

            Console.WriteLine("Коллекционное издание -- " + collection);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           
             
            Book newBookOne = new Book("Джон Р. Р. Толкин", "Властелин колец",350000, false);
            newBookOne.WriteBook();

            Book newBookTwo = new Book(" Алан Александр Милн", "Винни Пух", 53500, true);
            newBookTwo.WriteBook();

            Console.ReadKey();
        }
    }
    
}
    

