using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "vishnu" || textBox1.Text == "vikyath" || textBox1.Text == "madhuri")  && textBox2.Text == "admin123")
            {
                this.Hide();
                Admin_DashBoard f4 = new Admin_DashBoard();
                f4.ShowDialog();
            }
            else
                MessageBox.Show("Recheck your username and password or not authorized admin");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reader_login f1 = new Reader_login();
            f1.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
