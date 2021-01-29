namespace OOP3
{
    internal class RequestManagerBase
    {
        public void MakeRequest(ICreditManager creditManager)
        {
            HousingCreditManager housingCreditManager = new HousingCreditManager();
            housingCreditManager.Calculate();
        }
    }
}