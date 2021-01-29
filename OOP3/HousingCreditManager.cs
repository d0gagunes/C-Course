using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager :  ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Odeme Plani Hesaplandi") ;
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
