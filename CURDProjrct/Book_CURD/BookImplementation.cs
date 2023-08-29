using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Book_CURD
{
    public class BookImplementation
    {
        Book[] book;
        int count;
        public BookImplementation()
        {
            book = new Book[5];
            count = 0;
        }
        public void AddBook(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the id");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the book name");
                String bookname = Console.ReadLine();
                Console.WriteLine("Entre the price");
                int price = int.Parse(Console.ReadLine());
                book[count] = new Book(bid, bookname, price);
                count++;
            }
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < count; i++)
            {
                if (book[i] != null)
                {
                    Console.WriteLine(book[i]);
                }
            }
        }
        public void SearchBookById(int id)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].Book_id == id)
                    {
                        Console.WriteLine(book[i]);
                    }
                }
            }
        }
        public void UpadteBook(int id, int newprice)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].Book_id == id)
                    {
                        book[i].Price = newprice;
                    }
                }
            }
        }
        public void DeleteBook(int id)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i] != null)
                {
                    if (book[i].Book_id == id)
                    {
                        book[i] = null;
                    }
                }
            }
        }
    }
}
