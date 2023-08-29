using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CURDProject.Product_CURD
{
    public class Product1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }
    }

    public class ProductCRUD
    {
        private List<Product1> productlist;
        public ProductCRUD()
        {
            productlist = new List<Product1>()
            {
                new Product1{Id=1,Name="Laptop",Price=35000,Company="HP"},
                new Product1{Id=2,Name="Laptop",Price=37000,Company="Dell"}
            };
        }
      
        public List<Product1> GetProducts()
        {
            return productlist;
        }
        
        public Product1 GetProductById(int id)
        {
           
            Product1 product = new Product1();
            foreach (Product1 p in productlist)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        // add new product
        public void AddProduct(Product1 p)
        {
            productlist.Add(p);
        }
        // modify the product
        public void UpdateProduct(Product1 p) // p contains new data
        {
            foreach (Product1 item in productlist)
            {
                // item contains old product data
                if (item.Id == p.Id)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;

                }
            }
        }
        // remove product
        public void DeleteProduct(int id)
        {
            foreach (Product1 item in productlist)
            {
                if (item.Id == id)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }
    }



}
