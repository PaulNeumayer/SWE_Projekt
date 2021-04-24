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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        public event EventHandler OnPasswordCorrect;
        int wrongPasswordCounter = 0;

        private void buttonAddOk_Click(object sender, EventArgs e)
        {


            
                if (textBoxPassword.Text == "admin123")
                {
                    this.Hide();
                    OnPasswordCorrect(this, e);
            }

                else if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Please enter password!");
                }

                else
                {
                    MessageBox.Show("Password wrong");
                    wrongPasswordCounter++;                
                        
                }
            
                if (wrongPasswordCounter==3)
                {

                    this.Close();

                }

        }
    }
}
