using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class Library
    {
        private Book[] books;

        public Library()
        {
            books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"),
                new Book("Евгений Онегин") };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Length; i++)
            {
                yield return books[i];
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            yield return books[0];
            yield return books[1];
            yield return books[2];
        }
    }


    class Program
    {
        public static IEnumerable<int> Fibonacci
        {
            get
            {
                var a = 1;
                var b = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var c = a + b;
                    a = b;
                    b = c;
                    yield return c;
                }
            }
        }


        static void Main(string[] args)
        {


            Library lib = new Library();

            foreach(var b in  lib.GetBooks())
            {
                Console.WriteLine(b.Name);
            }


            foreach (var fib in Fibonacci)
            {
                if (fib < 100000)
                    Console.WriteLine(fib);
                else
                    break;
            }

        }

    }
}
