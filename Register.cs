using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Password = textBox2.Text;
            String repeatPassword = textBox6.Text;
            int minlength = 8;
            if (Password.Length >= minlength && Password.Any(char.IsUpper) && Password.Any(char.IsDigit) && (repeatPassword == Password))
            {
                Classes cl = new Classes();
                cl.Show();
                this.Hide();
            }
            else if (Password == ""  )
            {
                MessageBox.Show(" Please Enter Password ");

            }
             
            else
            {
                MessageBox.Show("Invalid Register ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
    }
    }

