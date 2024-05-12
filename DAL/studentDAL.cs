using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AppProps;
using System.Data;

namespace DAL
{
    public class studentDAL
    {
        dbcon con;
        string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=wtexp5;";
        public studentDAL()
        {
            con = new dbcon(constring);
        }
        public bool StudentInsertDAL(students c)
        {
            string query = "INSERT INTO cars (carID,make, model, year, price) VALUES ('" + c.CarID + "','" + c.Make + "','" + c.Model + "','" + c.Year + "','" + c.Price + "')";
            return con.UDI(query);
        }

        public bool StudentUpdateDAL(students c)
        {
            string query = "UPDATE cars SET make='" + c.Make + "', model='" + c.Model + "', year='" + c.Year + "', price='" + c.Price + "' WHERE carID='" + c.CarID + "'";
            return con.UDI(query);
        }

        public bool StudentDeleteDAL(students c)
        {
            string query = "DELETE FROM cars WHERE carID='" + c.CarID + "'";
            return con.UDI(query);
        }

        public DataTable StudentReadDAL(students c)
        {
            string query = "SELECT * FROM cars WHERE carID='" + c.CarID + "'";
            return con.search(query);
        }

        public DataTable StudentALLDAL(students c)
        {
            string query = "SELECT * FROM cars";
            return con.search(query);
        }
    }
}
