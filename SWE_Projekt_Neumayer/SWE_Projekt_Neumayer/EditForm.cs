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
        public EditForm()
        {
            InitializeComponent();
        }

        public void loadPerson(object sender, EventArgs args)
        {
            /*
            Person = (CustomEvents)args;
            textBox1.Text = Person.Person.ID;
            textBox2.Text = Person.Person.Email;
            textBox3.Text = Person.Person.Vorname;
            textBox4.Text = Person.Person.Nachname;
            textBox5.Text = Person.Person.DateofChange;
            this.Show();
            */
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
            /*
            Person.Person.Vorname = textBox1.Text;
            Person.Person.Nachname = textBox2.Text;
            Person.Person.Geschlecht = textBox3.Text;
            Person.Person.Alter = textBox4.Text;
            Person.Person.Studiengang = textBox5.Text;
            this.Hide();
            OnRefreshListRequested(this, new CustomEvents(Person.Person));
            */
        }
    }
}
