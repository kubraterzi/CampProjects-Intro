using GameCenter.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter
{
    public class Customer :IEntity
    {
        public int CustomerID { get; set; }
        public string CustomerIdentityKey { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime DateofBirth { get; set; }

    }
}
