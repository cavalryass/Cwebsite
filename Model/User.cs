using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User//The class is going to be the basic of all our kind of users and helps us lead with the users login
    {
       public enum Status//help with the status 
        {
            Admin,
            Project_M,
            Client,
            Secretary,
            Executive
        }

        public string userMail { get; set; }
        public string userPassword { get; set; }
        public string userFullName { get; set; }
        public string userPhone { get; set; }
        public Status userStatus { get; set; }

        public User(string userMail, string userPassword, string userFullName, string userPhone, Status userStatus)
        {
            this.userMail = userMail;
            this.userPassword = userPassword;
            this.userFullName = userFullName;
            this.userPhone = userPhone;
            this.userStatus = userStatus;
        }
    }
}
