namespace BankAccount
{
    using System;
    using System.Collections;
    public class Client
    {
        protected long DebitCard { get; set; }
        protected long AccountNumber { get; set; }
        private readonly Random _random = new Random();

        private int SecurityCode = 100;

        public string Name { get; set; }
        private ChequingAccount Chequing;
        private SavingAccount Saving;

        public Client()
        {
            Chequing = new ChequingAccount();
            Saving = new SavingAccount();
        }

        private decimal Balance;

        public void NewClient(){
            SecurityCode = _random.Next(100, 999);
            

            
        }
        
    }
}