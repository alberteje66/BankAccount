namespace BankAccount
{
    public class BankAccount : IBankAccount
    {
        protected decimal Balance;
        protected string AccountType;
        
        public BankAccount(decimal balance)
        {
            Balance = balance;
            AccountType = "Generic";
        }

        
    }
}