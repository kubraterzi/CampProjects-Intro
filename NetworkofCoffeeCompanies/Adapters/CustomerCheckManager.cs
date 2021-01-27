using MernisServiceReference;
using NetworkofCoffeeCompanies.Abstract;
using NetworkofCoffeeCompanies.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetworkofCoffeeCompanies.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }

        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var state = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.CustomerNationalityID), customer.CustomerName.ToUpper(),
                customer.CustomerLastName.ToUpper(), customer.DateofBirth.Year));

            Console.WriteLine("\nLogin succesful!\n");
            return state.Body.TCKimlikNoDogrulaResult;
        }

    }
}
