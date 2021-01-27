using NetworkofCoffeeCompanies.Abstract;
using NetworkofCoffeeCompanies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkofCoffeeCompanies.Concrete
{
    public class NeroCustomerManager : BaseCustomerManagerService
    {
        private ICustomerCheckService _customerCheckService = new CustomerCheckManager();

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);// Burada base anahtar kelimesi kalıtıldığı ana class ı ifade ediyor. I nherit ettiğimiz class ın içerisindeki Save metodu -> base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}
