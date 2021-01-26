using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;

namespace GameCenter.Adapters
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        //static async Task<bool> CheckIfRealPerson(Customer customer);
    }
}
