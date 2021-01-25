using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class CreditType3Manager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated - CreditType3");
        }

        public void Information()
        {
            Console.WriteLine("Bank Rate : %1.8");
        }
    }
}
