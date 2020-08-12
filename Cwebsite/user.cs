using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cwebsite
{
    public class user// the user class and database is going to include all the users in our site clinet and employees
    {
        public string mail { get; set; }//key
        public string password { get; set; }
        public string status { get; set; }

        public user(string mail, string password, string status)
        {
            this.mail = mail;
            this.password = password;
            this.status = status;
        }
    }
}