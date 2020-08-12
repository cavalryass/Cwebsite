using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cwebsite
{
    public class debt// more infornation...
    {
        public int id { get; set; }
        public string debtwonermMail { get; set; }
        public double debtAmount { get; set; }
        public string comment { get; set; }
        public DateTime dateOfdebt { get; set; }
    }
}