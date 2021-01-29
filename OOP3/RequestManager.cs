using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequestManager
    {
        public void MakeRequest(ICreditManager creditManager, ILoggerService loggerService)
        {

            creditManager.Calculate();
            loggerService.Log();
        }
        public void DoCreditPriorKnowledge (List <ICreditManager> credits )
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }

        
    }
}
