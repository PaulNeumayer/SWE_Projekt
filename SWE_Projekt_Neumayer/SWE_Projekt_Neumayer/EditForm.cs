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
    public partial class EditForm : Form
    {
        CustomEvents Customer;
        public event EventHandler OnRefreshListRequested;

        public EditForm()
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
            textBox5.Text = Customer.CustomerDataObj.myDate;
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UpDate = DateTime.Now.Date.ToString("dd.MM.yyyy");
            Customer.CustomerDataObj.iD = textBox1.Text;
            Customer.CustomerDataObj.eMail = textBox2.Text;
            Customer.CustomerDataObj.firstName = textBox3.Text;
            Customer.CustomerDataObj.lastName = textBox4.Text;
            Customer.CustomerDataObj.myDate = UpDate;
            this.Hide();
            OnRefreshListRequested(this, new CustomEvents(Customer.CustomerDataObj));
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
