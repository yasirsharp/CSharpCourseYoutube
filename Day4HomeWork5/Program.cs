using System;

namespace Day4HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Yasir");
            names.Add("Demirci");


            Console.WriteLine(names);
        }
    }
}
