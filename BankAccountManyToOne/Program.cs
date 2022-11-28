using System;
using System.Dynamic;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Hans", "Jensen", "Paradisæblevej 111");
            Client client2 = new Client("Viggo", "Hansen", "Paradisæblevej 113");
            //use the new client in the creation of a bankaccount
            BankAccount account = new BankAccount("forenings konto 1", 1000);
            account.AddClient(client1); 
            account.AddClient(client2);

            foreach (Client client in account.GetClients())
            {
                Console.WriteLine(client.ToString());
                Console.WriteLine(account.GetAccountHistory());
            }

            Console.ReadLine();
        }


    }
}
