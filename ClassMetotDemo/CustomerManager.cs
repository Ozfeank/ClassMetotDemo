using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " Başarıyla Eklenmiştir");
        }
        public static void List(Customer customer)
        {
            Console.WriteLine("Müşterinin Adı : " + customer.CustomerName+ " " + " Müşterinin Soyadı : " + customer.CustomerSurname + " " + " Müşterinin Telefon Numarası : " + customer.CustomerPhoneNo + " " + "Müşterinin Numarası  : " +customer.CustomerNo);

        }
        public static void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " Başarıyla Silinmiştir");
        }
    }
}
