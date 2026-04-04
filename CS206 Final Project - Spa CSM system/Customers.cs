using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    public class Customers
    {

        public string FirstName { get; set; } = " ";
        public string LastName { get; set; } = " ";
        public string Email { get; set; } = " ";

        public string Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Customers() { }

        public Customers(string firstname, string lastname, string email, string phone)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
        }

        public string GetDisplayText() => $"{FirstName} {LastName}, {Email}, {Phone}";

    }
}
