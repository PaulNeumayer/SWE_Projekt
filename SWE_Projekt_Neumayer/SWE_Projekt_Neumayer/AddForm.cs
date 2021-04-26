using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Projekt_Neumayer
{
    public partial class AddForm : Form
    {

        CustomEvents Customer;

        public event EventHandler OnRefreshListRequested;

        public AddForm()
        {
            InitializeComponent();

        }

        public void addCustomer(object sender, EventArgs args)
        {

            Customer = (CustomEvents)args;
            textBox1.Text = Customer.CustomerDataObj.iD;
            textBox2.Text = Customer.CustomerDataObj.eMail;
            textBox3.Text = Customer.CustomerDataObj.firstName;
            textBox4.Text = Customer.CustomerDataObj.lastName;
            textBox5.Text = Customer.CustomerDataObj.myDate;
            textBox8.Text = Customer.CustomerDataObj.street;
            textBox7.Text = Customer.CustomerDataObj.code;
            this.Show();

            /*
            textBox1.Text = CustomerDataObj.count.ToString(); // = System.Guid.NewGuid().ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = DateTime.Now.Date.ToString("dd.MM.yyyy"); 
            textBox6.Text = "0€";
            this.Show();
            */
        }

        public void checkMailSpelling(string eMailAdress)
        {



            bool condition1 = (eMailAdress.Split('@').Length - 1 == 1);

            //bool condition2 = (eMailAdress.Split('@')[1].Split('.').Length > 1);

            bool condition3 = (eMailAdress.Split('.')[eMailAdress.Split('.').Length - 1].Length >= 2 && eMailAdress.Split('.')[eMailAdress.Split('.').Length - 1].Length <= 4);

            bool condition4 = (eMailAdress.Split('@')[0].Length > 0);

            bool condition5 = (eMailAdress[0] != '.' && eMailAdress[eMailAdress.Length - 1] != '.' && eMailAdress.Split('@')[0][eMailAdress.Split('@')[0].Length - 1] != '.' && eMailAdress.Split('@')[1][0] != '.');

            bool condition6 = (!eMailAdress.Contains('ß') && !eMailAdress.Contains('"') && !eMailAdress.Contains(',') && !eMailAdress.Contains(';') &&
                                !eMailAdress.Contains(':') && !eMailAdress.ToLower().Contains('ä') && !eMailAdress.ToLower().Contains('ö') &&
                                !eMailAdress.ToLower().Contains('ü') && !eMailAdress.Contains('§') && !eMailAdress.Contains('€') && !eMailAdress.Contains('(') &&
                                !eMailAdress.Contains(')') && !eMailAdress.Contains('[') && !eMailAdress.Contains(']') && !eMailAdress.Contains('<') &&
                                !eMailAdress.Contains('µ') && !eMailAdress.Contains('>'));


            if (condition1 && /*condition2 &&*/ condition3 && condition4 && condition5 && condition6)
            {
                //return true;
            }

            else 
            {
                throw new ArgumentException("the email adress is misspelled");
            }


        }



        private void AddFom_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string[] arr = new string[6];
            //CustomerDataObj Customer = new CustomerDataObj(arr);
            var UpDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
            checkMailSpelling(textBox2.Text);
            Customer.CustomerDataObj.eMail = textBox2.Text;
            
            Customer.CustomerDataObj.firstName = textBox3.Text;
            Customer.CustomerDataObj.lastName = textBox4.Text;
            Customer.CustomerDataObj.myDate = UpDate;
            Customer.CustomerDataObj.balance = "0";
            Customer.CustomerDataObj.street = textBox8.Text;
            Customer.CustomerDataObj.code = textBox7.Text;

            //ID muss über LF Customers herausgefunden werden
            
            this.Hide();
            OnRefreshListRequested(this, new CustomEvents(Customer.CustomerDataObj));
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label_Nr_Click(object sender, EventArgs e)
        {

        }
    }
}
