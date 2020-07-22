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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Sample1
{
    public partial class Reader_login : Form
    {
        public Reader_login()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int logged_id;
        public int R_id()
        {
            return this.logged_id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");

            con.Open();

            String st = "Select count(*) from reader where reader_id =" +textBox1.Text;

            SqlCommand cmd = new SqlCommand(st, con);

            SqlDataReader sda = cmd.ExecuteReader();
            sda.Read();

            String i = sda[0].ToString();
             
            if (i =="1" ){
                 logged_id = Int32.Parse(textBox1.Text);
                this.Hide();
                Reader_Dashboard f3 = new Reader_Dashboard();
                f3.ShowDialog();
                i = "0";
            }
            else {
                MessageBox.Show("Recheck the ID no/Card no."+i );
                }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login f2 = new Admin_Login();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
