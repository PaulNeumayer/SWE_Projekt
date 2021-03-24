using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt_Neumayer
{
    public class CustomerDataObj
    {
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public string iD = string.Empty;
        public string eMail = string.Empty;
        public string balance = string.Empty;
        public string myDate = string.Empty;

        public CustomerDataObj(string[] Customer)
        {
            firstName = Customer[0];
            lastName = Customer[1];
            iD = Customer[2];
            eMail = Customer[3];
            balance = Customer[4];
            myDate = Customer[5];
        }

    }
}
