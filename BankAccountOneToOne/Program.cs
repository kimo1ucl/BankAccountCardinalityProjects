using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Hans", "Jensen", "Paradisæblevej 111");
            //use the new client in the creation of a bankaccount
            BankAccount account = new BankAccount(client, 1000);

            //Pull out the client from bankaccount to see if that the data matches
            Client testclient = account.Owner;
            string output = String.Format(
                "Account {0} was created for {1} {2} with {3} balance.",
                account.Number,
                testclient.FirstName,
                testclient.LastName,
                account.Balance
                );
            Console.WriteLine(output);

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            
            //throws error if not enough funds
            account.MakeWithdrawal(501, DateTime.Now, "Attempt to overdraw");
            
            Console.WriteLine(account.GetAccountHistory());


            Console.ReadLine();

         
           
        }

    }
}
