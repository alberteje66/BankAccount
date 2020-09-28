namespace BankAccount {
    using System.Collections;
    using System;
    public class Client {
        protected long DebitCard { get; set; }
        protected long AccountNumber { get; set; }
        private readonly Random _random = new Random ();

        private int SecurityCode = 100;

        public string Name { get; set; }
        private ChequingAccount Chequing;
        private SavingAccount Saving;

        public Client () {
            Chequing = new ChequingAccount ();
            Saving = new SavingAccount ();
        }

        public Client(decimal balance)
        {
            Balance = balance;
        }

        private decimal Balance;

        public void NewClient () {
            SecurityCode = _random.Next (100, 999);
            DebitCard = LongRandom (1000000000000000, 9999999999999999, _random);
            AccountNumber = LongRandom(100000000000, 999999999999, _random);
            Chequing = new ChequingAccount(Balance);
            Saving = new SavingAccount(Balance);
            
            //301,060,170,623
            //999999999999

        }
        public long LongRandom (long min, long max, Random rand) {
            byte[] buf = new byte[8];
            rand.NextBytes (buf);
            long longRand = BitConverter.ToInt64 (buf, 0);
            return (Math.Abs (longRand % (max - min)) + min);
        }

    }
}