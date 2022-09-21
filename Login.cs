using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4UU8U5C;Initial Catalog=Vigor;Integrated Security=True");
            string query = "Select * from Academy Where username ='" + textBox2.Text.Trim() + "' and password ='" + textBox1.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if ((dtbl.Rows.Count==1)|| (dtbl.Rows.Count == 2) || (dtbl.Rows.Count == 3) || (dtbl.Rows.Count == 4) || (dtbl.Rows.Count == 5))
            {
                Classes cl = new Classes();
                cl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login ");
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
