using System.Collections.Generic;

namespace HelpLocally.Domain
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string BankAccountNumber { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<User> Users { get; set; }
    }
}