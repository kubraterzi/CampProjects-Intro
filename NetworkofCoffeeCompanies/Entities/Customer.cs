using NetworkofCoffeeCompanies.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkofCoffeeCompanies.Entities
{
    public class Customer : IEntity
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string CustomerNationalityID { get; set; }

    }
}
