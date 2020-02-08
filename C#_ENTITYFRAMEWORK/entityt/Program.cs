using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace codefirstdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            productDBContext context = new productDBContext();
            var product = context.Products;
            var product1 = product.Add(new product() { productId = 1, Name = "badam drink", price = 20.99, quantity = "150ml", categoryId = 1 });
            var product2 = product.Add(new product() { productId = 2, Name = "coffee drink", price = 49.99, quantity = "250ml", categoryId = 2 });
            var product3 = product.Add(new product() { productId = 3, Name = "coke drink", price = 50.99, quantity = "200ml", categoryId = 3 });


         
            context.SaveChanges();



        }
    }
    public class productDBContext : DbContext
    {
        public productDBContext() : base("name=productDBContext")
        {

        }
        public DbSet<product> Products { get; set; }
        public DbSet<category> categories { get; set; }
    }
    public class product
    {
        public int productId { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public string quantity { get; set; }
        public int categoryId { get; set; }
    }
    public class category
    {
        public int categoryID { get; set; }
        public string name { get; set; }
        public string department{ get; set; }
    }
}

//    public class student
//    {
//        public int studentID { get; set; }
//        public string name { get; set; }
//    }
//    public class teacher
//    {
//        public int teacherID { get; set; }
//        public string name { get; set; }
       

//    }
//}