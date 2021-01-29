using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequimentCreditManager :  ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyac Kredisi Odeme Plani Hesaplandi");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
