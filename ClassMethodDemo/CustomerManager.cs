using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name + " eklendi.");
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine(
                "Değerli Müşterimiz, Bilgileriniz,\n"
                +
                "İsim : " + customer.Name + "\n"
                +
                "Soyisim : " + customer.LastName + "\n"
                +
                "Kart Numaranız : " +customer.CardNumber 
                +
                ". \nŞeklindedir, İyi Günler Dileriz."
            );
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + " : Silme işlemi başarılı.");
        }
    }
}
