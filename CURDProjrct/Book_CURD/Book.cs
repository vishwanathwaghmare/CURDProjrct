using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDProject.Book_CURD
{
    public class Book
    {
        int book_id;
        String book_name;
        int price;
        public Book(int book_id, string book_name, int price)
        {
            this.Book_id = book_id;
            this.Book_name = book_name;
            this.Price = price;
        }
        public override string ToString()
        {
            return book_id + " :" + book_name + " " + price;
        }
        public int Book_id { get => book_id; set => book_id = value; }
        public string Book_name { get => book_name; set => book_name = value; }
        public int Price { get => price; set => price = value; }
    }
}
