using System.Collections.Generic;

namespace Classes
{
    public class Client
    {
        private List<BankAccount> bankAccounts = new List<BankAccount>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public Client(BankAccount account, 
            string firstName, 
            string lastName, 
            string adress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.bankAccounts.Add(account);
        }
        public void AddBankAccount(BankAccount account)
        {
            bankAccounts.Add(account);   
        }
        public List<BankAccount> GetAllBankAccounts()
        {
            return bankAccounts;
        }

    }
}
