using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Laptop";
            product1.Price = 3999;
            product1.Explanation = "HP 15-RB013NT";

            Product product2 = new Product();
            product2.Name = "Mouse";
            product2.Price = 39;
            product2.Explanation = "HP Gaming Mouse";

            Product[] products = new Product[] {product1, product2 };

            //Type-Safe -- Tip Güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("----------METODLAR------------");

            //Instance - Örnek
            //Encapsulation
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            Console.WriteLine("-----------------------------");

            sepetManager.Ekle2("Headphone", "Red Headphone", 25);
            sepetManager.Ekle2("Keyboard", "Blue Headphone", 75);
            sepetManager.Ekle2("Phone", "Black Phone", 25);
        }
    }
}

//Do not repeat yourself - DRY
//Clean Code
//Best Practice