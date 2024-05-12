using AppProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace wt1
{
    public partial class StudentForm : System.Web.UI.Page
    {

        StudentBLL SBLL = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void s_inserted(object sender, EventArgs e)
        {
            students c = new students();
            c.CarID = carID.Text;
            c.Make = make.Text;
            c.Model = model.Text;
            c.Year = year.Text;
            c.Price = price.Text;

            if (SBLL.StudentInsertBLL(c))
                status.Text = "Insert was successfull";
            else
                status.Text = "Insert was not successfull";
        }

        protected void s_updated(object sender, EventArgs e)
        {
            students c = new students();
            c.CarID = carID.Text;
            c.Make = make.Text;
            c.Model = model.Text;
            c.Year = year.Text;
            c.Price = price.Text;

            if (SBLL.StudentUpdateBLL(c))
                status.Text = "Update was successfull";
            else
                status.Text = "Update was not successfull";
        }

        protected void s_deleted(object sender, EventArgs e)
        {
            students c = new students();
            c.CarID = carID.Text;
            c.Make = make.Text;
            c.Model = model.Text;
            c.Year = year.Text;
            c.Price = price.Text;

            if (SBLL.StudentDeleteBLL(c))
                status.Text = "Delete was successfull";
            else
                status.Text = "Delete was not successfull";
        }

        protected void s_read(object sender, EventArgs e)
        {
            students c = new students();
            c.CarID = carID.Text;
            DataTable dt = new DataTable();
            dt = SBLL.StudentReadBLL(c);


            if (dt.Rows.Count > 0)
            {
                status.Text = "Read was successfull";
                make.Text = dt.Rows[0]["make"].ToString();
                model.Text = dt.Rows[0]["model"].ToString();
                year.Text = dt.Rows[0]["year"].ToString();
                price.Text = dt.Rows[0]["price"].ToString();
            }
            
            else
                status.Text = "Read was not successfull";
        }

        protected void s_all(object sender, EventArgs e)
        {
            students st = new students();
            st.CarID = carID.Text;
            DataTable dt = new DataTable();
            dt = SBLL.StudentALLBLL(st);
            s_grid.DataSource = dt;
            s_grid.DataBind();
        }

        protected void ts(object sender, EventArgs e)
        {
            Response.Redirect("TeacherForm.aspx");
        }

        protected void sb(object sender, EventArgs e)
        {
            Response.Redirect("SubjectForm.aspx");
        }
    }
}