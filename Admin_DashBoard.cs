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
    public partial class Admin_DashBoard : Form
    {
        public Admin_DashBoard()
        {
            InitializeComponent();
        }
        string st = "";
        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "Select * from BRANCH"; 

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtb2 = new DataTable();
            sqlDA.Fill(dtb2);
            dataGridView1.DataSource = dtb2;
            con.Close();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
             st = "INSERT INTO READER(READER_ID,R_TYPE,R_NAME,R_ADDRESS) VALUES (@id, @TYPE, @NAME, @ADDRESS)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@TYPE", textBox3.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Reader recorded successfully");
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
             st = "UPDATE READER set RTYPE=@TYPE, RNAME=@NAME, ADDRESS=@ADDRESS Where (READERID=@id)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.Parameters.AddWithValue("@TYPE", textBox3.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("READER details updated successfully");
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "DELETE  from READER Where (READER_ID=@id)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reader deleted successfully");
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO DOCUMENT(DOC_ID,TITLE,P_DATE,PUB_ID) VALUES (@id, @TITLE, @DATE, @PUBID)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@TITLE", textBox6.Text);
            cmd.Parameters.AddWithValue("@DATE", textBox7.Text);
            cmd.Parameters.AddWithValue("@PUBID", textBox8.Text);
            cmd.ExecuteNonQuery();

             st = "INSERT INTO books(DOC_ID, ISBN) VALUES (@id, @ISBN)";
            SqlCommand cmd2 = new SqlCommand(st, con);
            cmd2.Parameters.AddWithValue("@id", textBox1.Text);
            cmd2.Parameters.AddWithValue("@ISBN", textBox10.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("New DOCUMENT added !");


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "UPDATE DOCUMENT set TITLE=@TYPE, P-DATE=@DATE, PUB_ID=@PUBID Where (DOC_ID=@id)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@TITLE", textBox6.Text);
            cmd.Parameters.AddWithValue("@DATE", textBox7.Text);
            cmd.Parameters.AddWithValue("@PUBID", textBox8.Text);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Document details updated successfully");
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "Select DOC_ID, TITLE, PUBNAME from DOCUMENT, publisher where document.pub_id = PUBLISHER.PUB_ID and DOC_ID like "+textBox9.Text;

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dataGridView2.DataSource = dtbl;
            con.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st1 = "select lib_id,reader_id,count(*) AS Noofbooksborrowed  from borrows GROUP BY lib_id, READER_ID ORDER BY LIB_ID, Noofbooksborrowed DESC; ";
        //    String st2 = "select lib_id,reader_id,count(*) AS Noofbooksborrowed  from borrows where LIB_ID=50002 GROUP BY READER_ID ORDER BY Noofbooksborrowed DESC; ";
         //   String st3 = "select reader_id,count(*) AS Noofbooksborrowed  from borrows where LIB_ID=50003 GROUP BY READER_ID ORDER BY Noofbooksborrowed DESC; ";
        //    String st4 = "select reader_id,count(*) AS Noofbooksborrowed  from borrows where LIB_ID=50004 GROUP BY READER_ID ORDER BY Noofbooksborrowed DESC; ";
        //    String st5 = "select reader_id,count(*) AS Noofbooksborrowed  from borrows where LIB_ID=50005 GROUP BY READER_ID ORDER BY Noofbooksborrowed DESC; ";

            SqlDataAdapter sqlDA1 = new SqlDataAdapter(st1, con);
        //    SqlDataAdapter sqlDA2 = new SqlDataAdapter(st2, con);
          //  SqlDataAdapter sqlDA3 = new SqlDataAdapter(st3, con);
          //  SqlDataAdapter sqlDA4 = new SqlDataAdapter(st4, con);
          //  SqlDataAdapter sqlDA5 = new SqlDataAdapter(st5, con);

            DataTable dtbl = new DataTable();
            sqlDA1.Fill(dtbl);
         //   sqlDA2.Fill(dtbl);

           
            dataGridView3.DataSource = dtbl;
            con.Close();

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO DOCUMENT(DOC_ID,TITLE,P_DATE,PUB_ID) VALUES (@id, @TITLE, @DATE, @PUBID)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox19.Text);
            cmd.Parameters.AddWithValue("@TITLE", textBox18.Text);
            cmd.Parameters.AddWithValue("@DATE", textBox17.Text);
            cmd.Parameters.AddWithValue("@PUBID", textBox16.Text);
            cmd.ExecuteNonQuery();

             st = "INSERT INTO journal_volume(DOC_ID, JVOLUME,EDITOR_ID) VALUES (@id, @JVOLUME,@EDITOR_ID)";
            SqlCommand cmd3 = new SqlCommand(st, con);
            cmd3.Parameters.AddWithValue("@id", textBox19.Text);
            cmd3.Parameters.AddWithValue("@JVOLUME", textBox14.Text);
            cmd3.Parameters.AddWithValue("@EDITOR_ID", textBox13.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("New DOCUMENT added !");


            con.Close();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO DOCUMENT(DOC_ID,TITLE,P_DATE,PUB_ID) VALUES (@id, @TITLE, @DATE, @PUBID)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@id", textBox26.Text);
            cmd.Parameters.AddWithValue("@TITLE", textBox25.Text);
            cmd.Parameters.AddWithValue("@DATE", textBox24.Text);
            cmd.Parameters.AddWithValue("@PUBID", textBox23.Text);
            cmd.ExecuteNonQuery();

             st = "INSERT INTO books(DOC_ID, C_DATE,C_LOCATION,C_EDITOR) VALUES (@id, @C_DATE,@C_LOCATION,@C_EDITOR)";
            SqlCommand cmd1 = new SqlCommand(st, con);
            cmd1.Parameters.AddWithValue("@id", textBox26.Text);
            cmd1.Parameters.AddWithValue("@C_DATE", textBox22.Text);
            cmd1.Parameters.AddWithValue("@C_LOCATION", textBox21.Text);
            cmd1.Parameters.AddWithValue("@C_EDITOR", textBox20.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("New DOCUMENT added !");


            con.Close();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();

            String st = "INSERT INTO PUBLISHER(PUBNAME,P_ADDRESS,PUB_ID) VALUES ( @PUBNAME, @P_ADDRESS, @PUB_ID)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@PUBNAME", textBox15.Text);
            cmd.Parameters.AddWithValue("@P_ADDRESS", textBox29.Text);
            cmd.Parameters.AddWithValue("@PUB_ID", textBox28.Text);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();

            String st = "select lib_id, doc_id, count(bor_number) from borrows where lib_id = "+ textBox27.Text+"group by lib_id, doc_id order by lib_id, count(bor_number) desc;";
          
            SqlDataAdapter sqlDA1 = new SqlDataAdapter(st, con);
           
            DataTable dtbl = new DataTable();
            sqlDA1.Fill(dtbl);
           
            dataGridView4.DataSource = dtbl;
            con.Close();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login f2 = new Admin_Login();
            f2.ShowDialog();
        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string st = "select top 10 d.doc_id, d.title from borrows b, document d " +
                "where b.doc_id = d.doc_id and year(borrow_date) = 2020 " +
                "group by d.doc_id, d.TITLE order by count(b.bor_number); ";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-KU85F3L5;Initial Catalog=nerds_feed;Integrated Security=True");
            con.Open();
                       

            SqlDataAdapter sqlDA = new SqlDataAdapter(st, con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            dataGridView5.DataSource = dtbl;
            con.Close();
        }
    }
}
