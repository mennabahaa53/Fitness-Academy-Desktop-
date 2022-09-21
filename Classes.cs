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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               Packdges pl = new Packdges();
               pl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Packdges pl = new Packdges();
            pl.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Packdges pl = new Packdges();
            pl.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Packdges pl = new Packdges();
            pl.Show();
        }
    }
}
