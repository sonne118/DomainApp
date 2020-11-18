using System;
using System.Collections.Generic;

namespace App.Domain.Model
{
    public class User
    {
        public Guid UserId { get; private set; }
        public Byte[] Timestamp { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string? Adresse { get; private set; }
        public string? EMail { get; private set; }
        public ICollection<UserAccount> UserAccounts { get; set; }

        private User()
        {
            // UserAccount = new HashSet<UserAccount>();
        }
        public User(string firstName, string lastName, string adresse, string eMail)
        {
            this.UserId = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adresse = adresse;
            this.EMail = eMail;
        }
    }
}
