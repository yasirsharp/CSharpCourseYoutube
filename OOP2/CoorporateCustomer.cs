using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CoorporateCustomer:Customer  //Coorporate = Tüzel
    {
        public string CompanyName { get; set; } //Şirket
        public string TaxNumber { get; set; }   //Vergi
    }
}