using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Naming Convention
        //Syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + product.Name);
        }
        public void Ekle2(string Name, string Explanation, double Price)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + Name);
        }
    }
}