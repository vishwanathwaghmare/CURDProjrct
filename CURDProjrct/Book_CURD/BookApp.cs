using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Book_CURD
{
    public class BookApp
    {
        static void Main(string[] args)
        {
            BookImplementation book = new BookImplementation();
            char ch = ' ';
            do
            {
                Console.WriteLine("1.Insert\n2.Show\n3.Update\n4.Delete\n 5.Serach");
                Console.WriteLine("enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How many book you want to add");
                        int n = Convert.ToInt32(Console.ReadLine());
                        book.AddBook(n);
                        break;
                    case 2:
                        Console.WriteLine("////////////////////");
                        book.ShowAllBooks();
                        break;
                    case 3:
                        Console.WriteLine("enter the id for update");
                        int bid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new price");
                        int price = int.Parse(Console.ReadLine());
                        book.UpadteBook(bid, price);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id for delete");
                        int dbid = Convert.ToInt32(Console.ReadLine());
                        book.DeleteBook(dbid);
                        break;
                    case 5:
                        Console.WriteLine("Enter id for search");
                        int id = int.Parse(Console.ReadLine());
                        book.SearchBookById(id);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you want to continue....");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');


        }


    }
}
