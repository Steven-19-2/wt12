using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    class dbcon
    {
        MySqlConnection con;

        public dbcon(string connectionstring)
        {
            con = new MySqlConnection(connectionstring);
        }


        public bool UDI(string query)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;
        }

        public DataTable search(string query)
        {
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MySqlCommand gmd = new MySqlCommand(query, con);
            con.Close();
            return dt;
        }
    }


}
