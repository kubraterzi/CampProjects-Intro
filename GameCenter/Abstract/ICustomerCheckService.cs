using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Abstract
{
    public interface ICustomerCheckService
    {
        bool CustomerCheck(Customer customer);
    }
}
