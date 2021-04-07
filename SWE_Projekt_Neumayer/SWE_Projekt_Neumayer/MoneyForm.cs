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
    public partial class MoneyForm : Form
    {
        CustomEvents Customer;
        public event EventHandler OnRefreshListRequested;

        public MoneyForm()
        {
            InitializeComponent();
        }

        public void loadPerson(object sender, EventArgs args)
        {

            Customer = (CustomEvents)args;
            textBox1.Text = Customer.CustomerDataObj.iD;
            textBox2.Text = Customer.CustomerDataObj.eMail;
            textBox3.Text = Customer.CustomerDataObj.firstName;
            textBox4.Text = Customer.CustomerDataObj.lastName;
            textBox6.Text = Customer.CustomerDataObj.balance;
            this.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //ok
        {
            this.Close();
        }

        private void button_MoneyCancel_Click(object sender, EventArgs e) //cancel
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //plus
        {
            int input=check_sum(textBox_sum.Text);
                        
            Customer.CustomerDataObj.balance = (Int32.Parse(Customer.CustomerDataObj.balance) + input).ToString();  // add balance with input & check input

            var UpDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
            Customer.CustomerDataObj.myDate = UpDate;

            OnRefreshListRequested(this, new CustomEvents(Customer.CustomerDataObj));

            textBox6.Text = Customer.CustomerDataObj.balance;
        }

        private void button_MoneyMinus_Click(object sender, EventArgs e) //minus
        {
            int input = check_sum(textBox_sum.Text);

            Customer.CustomerDataObj.balance = (Int32.Parse(Customer.CustomerDataObj.balance) - input).ToString();  // add balance with input & check input

            var UpDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
            Customer.CustomerDataObj.myDate = UpDate;
            
            OnRefreshListRequested(this, new CustomEvents(Customer.CustomerDataObj));

            textBox6.Text = Customer.CustomerDataObj.balance;
        }

        private int check_sum(string input)
        {
            int result = 0;

            try
            {
                result = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            // Output: Unable to parse ''

            return result;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
