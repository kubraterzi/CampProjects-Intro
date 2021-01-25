using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3    // Class, Interface oluşturduğun zaman önüne mutlaka önce public yaz.
{
    public class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void PreliminaryInformation(List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();
            }
        }
    }
}
