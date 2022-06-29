using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Individual customer1=new Individual();
            customer1.CustomerNo = "12345";
            customer1.Name = "engin";
            customer1.LastName = "demiroğ";
            customer1.TcNo = "1234565443343";
        
         Coorporate customer2=new Coorporate();
            customer2.Id = 2;
            customer2.CompanyName = "kodlama.io";
            customer2.CustomerNo = "54321";
            customer2.TaxNo = "6543";


            Customer customer3=new Individual();
            Customer customer4=new Coorporate();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }

    }
}
