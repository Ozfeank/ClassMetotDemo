using System;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName="Ahmet";
            customer1.CustomerSurname = "Taş";
            customer1.CustomerNo = 1;
            customer1.CustomerPhoneNo = "556 889 69 87";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Yasmin";
            customer2.CustomerSurname = "Gönül";
            customer2.CustomerNo = 2;
            customer2.CustomerPhoneNo = "512 689 87 48";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Cenk";
            customer3.CustomerSurname = "Mavi";
            customer3.CustomerNo = 3;
            customer3.CustomerPhoneNo = "536 913 66 58";

            Customer customer4 = new Customer();
            customer4.CustomerName = "Deniz";
            customer4.CustomerSurname = "Altun";
            customer4.CustomerNo = 4;
            customer4.CustomerPhoneNo = "578 963 12 54 ";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            for (int i = 0; i < customers.Length; i++)
            {
                CustomerManager.Add(customers[i]);
            }
            foreach ( var customer in customers )
            {
                CustomerManager.List(customer);
            }
            for (int x = 0; x < customers.Length; x++)
            {
                CustomerManager.Delete(customers[x]);
            }
            Console.ReadKey();
        }
    }
}
