using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requimentCreditManager = new RequimentCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RequestManager requestManager = new RequestManager();
            requestManager.MakeRequest(housingCreditManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { requimentCreditManager, vehicleCreditManager };
       //   requestManager.DoCreditPriorKnowledge(credits);



        }
    }
}
