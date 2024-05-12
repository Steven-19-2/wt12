using AppProps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class teacherDAL
    {
        dbcon con;
        string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=wtexp5;";
        public teacherDAL()
        {
            con = new dbcon(constring);
        }
        public bool TeacherInsertDAL(teachers p)
        {
            string query = $"INSERT INTO purchases (pid, userID, carID, purchaseDate) VALUES ('{p.PID}', '{p.UserID}', '{p.CarID}', '{p.PurchaseDate}')";
            return con.UDI(query);
        }

        public bool TeacherUpdateDAL(teachers p)
        {
            string query = $"UPDATE purchases SET userID='{p.UserID}', carID='{p.CarID}', purchaseDate='{p.PurchaseDate}' WHERE pid='{p.PID}'";
            return con.UDI(query);
        }

        public bool TeacherDeleteDAL(teachers p)
        {
            string query = $"DELETE FROM purchases WHERE pid='{p.PID}'";
            return con.UDI(query);
        }

        public DataTable TeacherReadDAL(teachers p)
        {
            string query = $"SELECT * FROM purchases WHERE pid='{p.PID}'";
            return con.search(query);
        }

        public DataTable TeacherALLDAL(teachers p)
        {
            string query = "SELECT * FROM purchases";
            return con.search(query);
        }
    }
}
