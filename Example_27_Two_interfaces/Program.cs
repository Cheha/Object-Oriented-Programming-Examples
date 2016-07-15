using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_27_Two_interfaces
{
    interface IPrintedBook
    {
        int Pages { get; }
        void Publish();
    }

    interface IEBook
    {
        int Pages { get; }
        void Publish();
    }

    //class Book : IPrintedBook, IEBook
    //{
    //    public int Pages { get; private set; }
    //    public Book(int pages)
    //    {
    //        this.Pages = pages;
    //    }

    //    public void Publish()
    //    {
    //        Console.WriteLine("Book is publishing");
    //    }
    //}

    class Book : IPrintedBook, IEBook
    {
        public int Pages { get; private set; }
        public Book(int pages)
        {
            this.Pages = pages;
        }

        void IPrintedBook.Publish()
        {
            Console.WriteLine("Book is printing");
        }

        void IEBook.Publish()
        {
            Console.WriteLine("Book is uploadign");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int book_pages = 500;

            //Book book = new Book(book_pages);
            //book.Publish();

            Book book = new Book(book_pages);
            IPrintedBook printedBook = (IPrintedBook)book;
            printedBook.Publish();

            IEBook eBook = (IEBook)book;
            eBook.Publish();
        }
    }
}
