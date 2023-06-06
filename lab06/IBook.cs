using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal interface IBook
    {
        string TenSach { get; set; }
        string TacGia {get; set; }
        string NXB { get; set; }
        int nam {get; set; }
        string ISBN { get; set; }
        List<string> Chuong { get; set; }

    }

    class Book : IBook
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NXB { get; set; }
        public int nam { get; set; }
        public string ISBN { get; set; }
        public List<string> Chuong { get; set; }
    }

    class BookList
    {
        private List<Book> books;

        public BookList()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ShowList()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Ten : "+ book.TenSach);
                Console.WriteLine("Tac Gia : " + book.TacGia);
                Console.WriteLine("NXB : " + book.NXB);
                Console.WriteLine("Nam XB : " + book.nam);
                Console.WriteLine("TSBN : " + book.ISBN);
                foreach(string str in book.Chuong)
                {
                    Console.WriteLine($"{str}");
                }
                Console.WriteLine();
            }
            
        }

        public void SortByTG()
        {
            books.Sort((book1, book2)=> book1.TacGia.CompareTo(book2.TacGia));
        }

        public void SortByTenSach()
        {
            books.Sort((book1, book2) => book1.TenSach.CompareTo(book2.TenSach));
        }
        public void SortByNamXB()
        {
            books.Sort((book1, book2) => book1.nam.CompareTo(book2.nam));
        }
    }
}
