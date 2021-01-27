using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSystem
{
    class CustomerManager : ICustomerControlService
    {
        public void Add(Customer customer)
        {
            CheckIfRealPerson(customer);
            Console.WriteLine("Kişi Bilgileri Sisteme Kayıt Edildi : " + customer.FirstName + customer.LastName);
        }
        private bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Kişi Bilgileri Sistemden Silinmiştir.. " + customer.FirstName + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kişi Bilgileri Güncellenmiştir .." + customer.FirstName + customer.LastName);
        }
    }
}
