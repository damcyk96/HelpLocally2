using System.Collections.Generic;

namespace HelpLocally.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public User()
        {
        }

        public User(string login, string password, string role)
        {
            Login = login;
            Password = password;
            Role = role;
        }
    }
}