using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sample1
{
    public class DataBaseConnection
    {

        MySqlConnection obj = new MySqlConnection("server=localhost;user id=root;database=nerds_feed");

        public void OpenConnection()
        {
            obj.Open();
        }

        public void CloseConnection()
        {
            obj.Close();
        }

        public DataTable readvalue()
        {


            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from nerds_feed.Document", obj);
            da.Fill(dt);
            return dt;

        }

    }
}