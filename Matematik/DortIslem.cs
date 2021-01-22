using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Sonuç = " + result);
        }
        public void Cikar(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Sonuç = " + result);
        }
        public void Bol(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Sonuç = " + result);
        }
        public void Carp(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Sonuç = " + result);
        }
    }
}
