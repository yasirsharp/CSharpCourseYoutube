using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yasir Demirci
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "100001";
            customer1.CustomerName = "Yasir";
            customer1.CustomerLastName = "Demirci";
            customer1.TCNumber = "100000000000";
            //-----------------------------------

            //Malik Demirci
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "200002";
            customer1.CustomerName = "Malik";
            customer1.CustomerLastName = "Demirci";
            customer1.TCNumber = "200000000000";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("---------------------------------------------------");


        }
    }
}
        // Gerçek Müşteri - Tüzel Müşteri
        //S O L I D