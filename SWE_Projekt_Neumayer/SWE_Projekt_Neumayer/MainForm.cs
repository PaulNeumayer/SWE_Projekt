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
    public partial class MainForm : Form
    {
        //Eventhandler zum Aufrufen des Editors
        public event EventHandler OnEditRequested;
        public event EventHandler OnMoneyRequested;
        public event EventHandler OnFileHanldingRequested;
        public event EventHandler OnFileSavingRequested;
        public event EventHandler RefreshList2;
        public event EventHandler OnAddRequested;

        CustomEvents LF;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            OnAddRequested(this, e);
        }

        public void ListView(object sender, EventArgs arg)
        {
            LF = (CustomEvents)arg;
            listBox1.DataSource = LF.Customers;

            string filter = LF.filter;
            List<CustomerDataObj> CustomersFiltered = new List<CustomerDataObj>();
            foreach (object element in LF.Customers)
                {

                }
        }

        public void RefreshList(object sender, EventArgs args)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = LF.Customers;
        }

        public void WriteListToCSV(object sender,EventArgs args)
        {
            LF = (CustomEvents)args;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("firstName;LastName;iD;eMail;balance;myDate");
            foreach (var item in LF.Customers)
            {
                sb.AppendLine(LF.CustomerDataObj.firstName + LF.CustomerDataObj.lastName + LF.CustomerDataObj.iD + LF.CustomerDataObj.eMail + LF.CustomerDataObj.balance + LF.CustomerDataObj.myDate);
            }

            Console.WriteLine(sb.ToString());
            System.IO.File.WriteAllText(
                System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "List1.csv"),
                sb.ToString());
            Console.ReadLine();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OnFileHanldingRequested(((Button)sender), e);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string filter = textBoxSearch.Text;
            RefreshList2(this, new CustomEvents(filter));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                OnEditRequested(this, new CustomEvents((CustomerDataObj)listBox1.SelectedItem));
            }
            catch
            {
                MessageBox.Show("Keine Daten Geladen");
            }
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            try
            {
                OnMoneyRequested(this, new CustomEvents((CustomerDataObj)listBox1.SelectedItem));
            }
            catch
            {
                MessageBox.Show("Keine Daten Geladen");
            }
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            OnFileSavingRequested(this, new CustomEvents((CustomerDataObj)listBox1.SelectedItem));
        }
    }
}
