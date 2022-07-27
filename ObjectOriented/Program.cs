using System;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer();
            customer.Id = 1;
            customer.CustomerNo = "123";
            customer.Fullname = "Fatih EŞGÜN";
            customer.IdenityNumber = "12345678901";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CompanyName = "Elsa Yazılım";
            customer2.CustomerNo = "112";
            customer2.TaxNo = "1234567890";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);

        }
    }
}
