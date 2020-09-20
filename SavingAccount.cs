namespace BankAccount
{
    public class SavingAccount : IBankAccount
    {
        private IBankAccount _savingaccount;
        private decimal Balance;
        
        public string AccountType;

        public SavingAccount()
        {
            _savingaccount = new BankAccount(Balance);
            AccountType = "Saving";
        }

        public SavingAccount(decimal newbalance)
        {
            Balance = newbalance;
            _savingaccount = new BankAccount(Balance);
            AccountType = "Saving";
        }

        public decimal Withdraw(decimal amount){
            Balance -= amount;
            return Balance;
        }

        public decimal Deposit(decimal amount) {
            Balance += amount;
            return Balance;
        }

        public decimal GetBalanc() {
            return Balance;
        }
    }
}