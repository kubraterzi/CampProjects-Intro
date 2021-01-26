using GameCenter.Adapters;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.Concrete
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }
        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var state = await(client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.CustomerIdentityKey), customer.CustomerName.ToUpper(),
                customer.CustomerLastName.ToUpper(), customer.DateofBirth.Year));

            Console.WriteLine("\nLogin succesful!\n");
            return state.Body.TCKimlikNoDogrulaResult;
        }
    }
}
