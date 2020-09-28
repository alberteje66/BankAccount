namespace BankAccount {
    public class ChequingAccount : IBankAccount {

        IBankAccount _account;
        protected decimal Balance;
        protected string AccountType;
        public ChequingAccount()
        {
            _account = new BankAccount(Balance);
            AccountType = "Chequing";
        }
        public ChequingAccount(decimal newbalance)
        {
            Balance = newbalance;
             _account = new BankAccount(Balance);
            AccountType = "Chequing";
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