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

        
        public event EventHandler OnRefreshListRequested;

        public AddForm()
        {
            InitializeComponent();

        }

        public void addPerson(object sender, EventArgs args)
        {
            
            textBox1.Text = CustomerDataObj.count.ToString(); // = System.Guid.NewGuid().ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = DateTime.Now.Date.ToString("dd.MM.yyyy"); 
            textBox6.Text = "0€";
            this.Show();

        }


        

        private void AddFom_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6];
            CustomerDataObj Customer = new CustomerDataObj(arr);
            Customer.eMail = textBox2.Text;
            Customer.firstName = textBox3.Text;
            Customer.lastName = textBox4.Text;
            Customer.myDate = textBox5.Text;
            this.Hide();
            OnRefreshListRequested(this, new CustomEvents(Customer));
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Nr_Click(object sender, EventArgs e)
        {

        }
    }
}
