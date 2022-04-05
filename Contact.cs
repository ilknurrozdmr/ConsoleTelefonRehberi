using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulaması
{
    class Contact
    {
        public string FirstName;
        public string LastName;
        public string Phone;

        public Contact(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }
    }
}
