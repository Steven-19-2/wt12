using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class subjectDAL
    {
        dbcon con;
        string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=wtexp5;";
        public subjectDAL()
        {
            con = new dbcon(constring);
        }
        public bool SubjectInsertDAL(subjects u)
        {
            string query = "insert into users values('" + u.UserId + "','" + u.Username + "','" + u.Email + "','" + u.Password + "','" + u.Role + "') ";
            return con.UDI(query);
        }

        public bool SubjectUpdateDAL(subjects u)
        {
            string query = "update users set username='" + u.Username + "', email='" + u.Email + "',password='" + u.Password + "',role='" + u.Role + "'where userId='" + u.UserId + "'";
            return con.UDI(query);
        }

        public bool SubjectDeleteDAL(subjects u)
        {
            string query = "delete from users where userId='" + u.UserId + "'";
            return con.UDI(query);
        }

        public DataTable SubjectReadDAL(subjects u)
        {
            string query = "select * from users where userId='" + u.UserId + "'";
            return con.search(query);
        }

        public DataTable SubjectALLDAL(subjects u)
        {
            string query = "select * from users";
            return con.search(query);
        }
    }
}
