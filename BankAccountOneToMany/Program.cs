using System;
using System.Dynamic;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the bankaccount for the client
            BankAccount account1 = new BankAccount("Konto 1", 1000);
            // use the bankacount when creating the Client.
            Client client = new Client(account1,"Hans", "Jensen", "Paradisæblevej 111");

            //create another bankaccount, and add it also to the same client
            client.AddBankAccount(new BankAccount("Konto 2", 500));
            
            foreach(BankAccount account in client.GetAllBankAccounts())
            {
                Console.WriteLine(account.Name);
                Console.WriteLine(account.GetAccountHistory());
            }

            Console.ReadLine();
        }
        

    }
}
