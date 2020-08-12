using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cwebsite
{
    public class client
    {
        public string mail { get; set; }//key
        public string password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public client(string mail, string password, string name, string address, string phone)
        {
            this.mail = mail;
            this.password = password;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
}