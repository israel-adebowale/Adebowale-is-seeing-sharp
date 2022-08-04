using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acm.BLNew
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            Object myObject = new Object();
            Console.WriteLine($"Customer: {customer.ToString()}");
            return customer;
        }
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
