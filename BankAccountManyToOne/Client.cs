using System.Collections.Generic;

namespace Classes
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public Client(string firstName, 
            string lastName, 
            string adress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
        }
        public override string ToString()
        {
            string output = string.Empty;
            output = string.Format("fornavn:{0} - efternavn:{1} - Adresse:{2}",
                this.FirstName, this.LastName, this.Adress);
            return output;  

        }
    }
}
