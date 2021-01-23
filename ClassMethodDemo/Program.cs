using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Yasir";
            customer1.LastName = "Demirci";
            customer1.CardNumber = 1000001;

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.Name = "Malik";
            customer2.LastName = "Demirci";
            customer2.CardNumber = 1000002;

            Customer customer3 = new Customer();
            customer3.Id = 1;
            customer3.Name = "Ahmet Arif";
            customer3.LastName = "Demirci";
            customer3.CardNumber = 1000003;

            Customer customer4 = new Customer();
            customer4.Id = 1;
            customer4.Name = "Yunus Emre";
            customer4.LastName = "Demirci";
            customer4.CardNumber = 1000004;
            //-------------------------------

            //-------------------------------
            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer1);
            Console.WriteLine("\n");
            customerManager.ListCustomer(customer1);

                Console.WriteLine("-----------------------------------------------");

            customerManager.CustomerAdd(customer2);
            Console.WriteLine("\n");
            customerManager.ListCustomer(customer2);

                Console.WriteLine("-----------------------------------------------");

            customerManager.CustomerAdd(customer3);
            Console.WriteLine("\n");
            customerManager.ListCustomer(customer3);

                Console.WriteLine("-----------------------------------------------");

            customerManager.CustomerAdd(customer4);
            Console.WriteLine("\n");
            customerManager.ListCustomer(customer4);

                Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("-----------------------------------------------------------------------------------------");

            customerManager.CustomerDelete(customer1);
            Console.WriteLine("\n");
            customerManager.CustomerDelete(customer2);
            Console.WriteLine("\n");
            customerManager.CustomerDelete(customer3);
            Console.WriteLine("\n");
            customerManager.CustomerDelete(customer4);
        }

    }
}
