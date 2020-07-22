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

namespace Sample1
{
    public partial class Reader_Dashboard : Form
    {
        string st = "";
        public Reader_Dashboard()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int searchby = comboBox1.SelectedIndex;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            if (searchby == 1)
            {
               // label4.Text = "Title";
                st = "Select doc_id, title, PUBNAME from DOCUMENT, publisher where document.pub_id = publisher.pub_id and DOCUMENT.TITLE LIKE '%" + textBox1.Text.ToString() + "%'";

            }
            else if (searchby == 2)
            {
                //label4.Text = "Publisher Name";
                st = "Select doc_id, title, PUBNAME from DOCUMENT, publisher where document.pub_id = publisher.pub_id and PUBNAME LIKE '%" + textBox1.Text.ToString() + "%'";

            }
            else if (searchby == 0)
            {
                //label4.Text = "Document";
                st = "Select doc_id, title, PUBNAME from DOCUMENT, publisher where document.pub_id = publisher.pub_id and doc_id = " + textBox1.Text;


            }

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dgv1.DataSource = dtbl;
            con.Close();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow srow = dgv1.Rows[index];

            //label4.Text = srow.Cells[0].Value.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            Reader_login f1 = new Reader_login();
            string st = "insert into borrows(BOR_NUMBER, READER_ID, DOC_ID, COPY_NO, LIB_ID, BORROW_DATE, RETURN_DATE)" +
                         "values((select(max(BOR_NUMBER) + 1) from BORROWS), 90001, 10002 ,(1 + (select count(*) from borrows where lib_id = 50002  and doc_id = 10002  group by doc_id))," +
                           "50002, getdate(), null);";
            string st1 = "insert into borrows (BOR_NUMBER, READER_ID, DOC_ID,COPY_NO, LIB_ID,BORROW_DATE, RETURN_DATE)" +
             "values((select(max(BOR_NUMBER) + 1) from BORROWS), @readerid, @docid ,(1 + (select count(*) from borrows where lib_id = @slib  and doc_id = @sdoc  group by doc_id))," +
                  "@libid, getdate(), null) ; ";


            SqlCommand cmd1 = new SqlCommand(st, con);
              //cmd.Parameters.AddWithValue("@readerid", f1.R_id());
              //cmd.Parameters.AddWithValue("@docid", textBox5.Text);
              //cmd.Parameters.AddWithValue("@libid", textBox6.Text);
              //cmd.Parameters.AddWithValue("@slib", textBox6.Text);
              //cmd.Parameters.AddWithValue("@sdoc", textBox5.Text);
             cmd1.ExecuteNonQuery();

            MessageBox.Show("Document Borrowed!");

            con.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reader_login f1 = new Reader_login();
            f1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reader_login f1 = new Reader_login();
            f1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();

            st = "Select doc_id, title, PUBNAME from DOCUMENT, publisher where document.pub_id = publisher.pub_id and PUBNAME LIKE '%" + textBox2.Text.ToString() + "%'";

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();

            st = "SELECT * FROM reserves where READER_ID = " + textBox3.Text;

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            Reader_login f1 = new Reader_login();
            string st = "UPDATE BORROWS SET RETURN_DATE = GETDATE() WHERE BOR_NUMBER =" + textBox4.Text; // 60001; ";
           


            SqlCommand cmd1 = new SqlCommand(st, con);
            //cmd.Parameters.AddWithValue("@readerid", f1.R_id());
            //cmd.Parameters.AddWithValue("@docid", textBox5.Text);
            //cmd.Parameters.AddWithValue("@libid", textBox6.Text);
            //cmd.Parameters.AddWithValue("@slib", textBox6.Text);
            //cmd.Parameters.AddWithValue("@sdoc", textBox5.Text);
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Document Returned!");

            con.Close();



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            Reader_login f1 = new Reader_login();

            st = "SELECT * FROM borrows where READER_ID =" +textBox7.Text;    //f1.R_id();

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            Reader_login f1 = new Reader_login();
            string st = "insert into reserves(RES_NUMBER, READER_ID, DOC_ID, COPY_NO, LIB_ID, D_TIME)" +
                         "values((select(max(RES_NUMBER) + 1) from RESERVES), 90001, 10002 ,(1 + (select count(*) from RESERVES where lib_id = 50002  and doc_id = 10002  group by doc_id))," +
                           "50002, getdate());";
            string st1 = "insert into borrows (BOR_NUMBER, READER_ID, DOC_ID,COPY_NO, LIB_ID,BORROW_DATE, RETURN_DATE)" +
             "values((select(max(BOR_NUMBER) + 1) from BORROWS), @readerid, @docid ,(1 + (select count(*) from borrows where lib_id = @slib  and doc_id = @sdoc  group by doc_id))," +
                  "@libid, getdate(), null) ; ";


            SqlCommand cmd1 = new SqlCommand(st, con);
            //cmd.Parameters.AddWithValue("@readerid", f1.R_id());
            //cmd.Parameters.AddWithValue("@docid", textBox5.Text);
            //cmd.Parameters.AddWithValue("@libid", textBox6.Text);
            //cmd.Parameters.AddWithValue("@slib", textBox6.Text);
            //cmd.Parameters.AddWithValue("@sdoc", textBox5.Text);
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Document Reserved!");

            con.Close();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reader_login f1 = new Reader_login();
            f1.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Reader_login f1 = new Reader_login();
            f1.ShowDialog();
        }
    }
}

