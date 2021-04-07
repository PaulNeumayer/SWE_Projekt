using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_Projekt_Neumayer
{
    class CustomerDataList
    {
        public event EventHandler OnListRequested;
        public event EventHandler OnAddCustomer;
        List<CustomerDataObj> Customers = new List<CustomerDataObj>();

        public CustomerDataList()
        {

        }

        public void CustomerListHandler(object sender, EventArgs args)
        {
            CustomEvents ce = (CustomEvents)args;

            FillList(ce.Temp);
        }

        public void AddCustomerToList(object sender, EventArgs args)
        {
            string[] Temp = new string[6];
            CustomerDataObj Customer = new CustomerDataObj(Temp);
            Customers.Add(Customer);

            OnAddCustomer(this, new CustomEvents(Customer));
        }

        private void FillList(String[,] Data)
        {
            string[] Temp = new string[6];
            for (int k = 1; k < Data.GetLength(0); k++)
            {
                for (int i = 0; i < Temp.Length-1; i++)
                {
                    Temp[i] = Data[k, i];
                }

                CustomerDataObj Customer = new CustomerDataObj(Temp);
                Customers.Add(Customer);
            }
            OnListRequested(this, new CustomEvents(Customers));
        }

        
    }
}
