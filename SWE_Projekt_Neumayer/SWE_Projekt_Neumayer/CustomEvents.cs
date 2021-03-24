using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode
{
    class CustomEvents:EventArgs
    {
        public string[,] Temp { get; private set; }
        public List<CustomerDataObj> Customers = new List<CustomerDataObj>();
        public CustomerDataObj CustomerDataObj;
        public string filter;

        public CustomEvents(string[,] Customers)
        {
            Temp = Customers;
        }

        public CustomEvents(List<CustomerDataObj> Customers)
        {
            this.Customers = Customers;
        }

        public CustomEvents(CustomerDataObj Customer)
        {
            this.CustomerDataObj = Customer;
        }

        public CustomEvents(string filter)
        {
            this.filter = filter;
        }
    }
}
