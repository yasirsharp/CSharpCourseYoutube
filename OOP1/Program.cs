using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)              
        {
            Product product1 = new Product();
            product1.Id          = 1;
            product1.ProductName = "Laptop";         
            product1.CategoryId  = 2;
            product1.UnitPrice   = 5999;
            product1.UnitInStock = 100;

            Product product2 = new Product {Id =2, ProductName="Processor",
                CategoryId = 2, UnitPrice=2666, UnitInStock=1
            };

            //Case sensitive
            //PascalCase   //camelCase
            //Steak                         //Heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(1,2);

            int toplamaSonucu = productManager.Topla(1,2);
            Console.WriteLine(toplamaSonucu * 2);
        }
    }
}