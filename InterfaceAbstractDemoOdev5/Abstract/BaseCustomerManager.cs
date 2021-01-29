using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoOdev5.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FirstName);
        }
    }
}
