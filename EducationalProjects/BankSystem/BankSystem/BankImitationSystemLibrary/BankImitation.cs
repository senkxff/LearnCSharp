namespace BankImitationSystemLibrary
{
    public class BankImitation
    {
        private double baseMoneyCount = 0;

        public void PutMoney(double moneyCount)
        {
            baseMoneyCount += moneyCount;
        }
        
        public void TakeMoney(double moneyCount)
        {
            if (moneyCount > baseMoneyCount)
            {

            }
            else
            {
                baseMoneyCount -= moneyCount;
            }
        }
    }
}
