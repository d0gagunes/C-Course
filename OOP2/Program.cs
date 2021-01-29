using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Doga";
            customer1.Surname = "Gunes";
            customer1.TcNo = "1234567890";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CompanyName = "Kodlama";
            customer2.Id = 2;
            customer2.TaxNo = "4384737537";
            customer2.CustomerNo = "5365646";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();


    }
}
