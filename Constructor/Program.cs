using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Yasir", LastName= "Demirci", City="Düzce"};

            Customer customer2 = new Customer(2,"Veysel", "Karani", "Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mahmut";
            customer3.LastName = "İnce";
            customer3.City = "Düzce";

            Console.WriteLine(customer3);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        // Default Constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}