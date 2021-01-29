using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer  // Inheritance (miras) 
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
