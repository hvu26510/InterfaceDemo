using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();

            do
            {
                Book book = new Book();
                Console.WriteLine("Nhap Ten Sach");
                book.TenSach = Console.ReadLine();
                Console.WriteLine("Nhap Ten NXB");
                book.NXB = Console.ReadLine();
                Console.WriteLine("Nhap Ten tac gia");
                book.TacGia = Console.ReadLine();
                Console.WriteLine("Nhap nam xb");
                book.nam = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ISBN");
                book.ISBN = Console.ReadLine();
                List<string> x = new List<string>();
                int count = 0;
                do
                {
                    
                    Console.WriteLine("Nhap chuong " + count++);
                    string chuong = Console.ReadLine();
                    x.Add(chuong);
                    Console.WriteLine("Bam 'q' de dung nhap chuong");
                    string check = Console.ReadLine();
                    if (check == "q")
                    {
                        break;
                    }
                } while (true);

                book.Chuong = x;

                bookList.AddBook(book);

                Console.WriteLine("Bam 'q' de dung nhap sach");
                string checkBook = Console.ReadLine();
                if (checkBook == "q")
                {
                    break;
                }
            } while (true);

            bookList.ShowList();

            Console.ReadLine();


        }
    }
}
