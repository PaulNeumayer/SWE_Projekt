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
        public event EventHandler OnFileHanldingRequested;
        public event EventHandler RefreshList2;

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
    }
}
