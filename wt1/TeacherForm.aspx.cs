using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;
using System.Data;

namespace wt1
{
    public partial class TeacherForm : System.Web.UI.Page
    {
        TeacherBLL TBLL = new TeacherBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void t_inserted(object sender, EventArgs e)
        {
            teachers st = new teachers();
            st.PID = pid.Text;
            st.UserID = userID.Text;
            st.CarID = carID.Text;
            st.PurchaseDate = purchaseDate.Text;

            if (TBLL.TeacherInsertBLL(st))
                status.Text = "Insert was successfull";
            else
                status.Text = "Insert was not successfull";
        }

        protected void t_updated(object sender, EventArgs e)
        {
            teachers st = new teachers();
            st.PID = pid.Text;
            st.UserID = userID.Text;
            st.CarID = carID.Text;
            st.PurchaseDate = purchaseDate.Text;

            if (TBLL.TeacherUpdateBLL(st))
                status.Text = "Update was successfull";
            else
                status.Text = "Update was not successfull";
        }

        protected void t_deleted(object sender, EventArgs e)
        {
            teachers st = new teachers();
            st.PID = pid.Text;
            st.UserID = userID.Text;
            st.CarID = carID.Text;
            st.PurchaseDate = purchaseDate.Text;

            if (TBLL.TeacherDeleteBLL(st))
                status.Text = "Delete was successfull";
            else
                status.Text = "Delete was not successfull";
        }

        protected void t_read(object sender, EventArgs e)
        {
            teachers st = new teachers();
            st.PID = pid.Text;
            DataTable dt = new DataTable();
            dt = TBLL.TeacherReadBLL(st);


            if (dt.Rows.Count > 0)
            {
                status.Text = "Read was successfull";
                userID.Text = dt.Rows[0]["userID"].ToString();
                carID.Text = dt.Rows[0]["carID"].ToString();
                purchaseDate.Text = dt.Rows[0]["purchaseDate"].ToString();
            }

            else
                status.Text = "Read was not successfull";
        }

        protected void t_all(object sender, EventArgs e)
        {
            teachers st = new teachers();
            st.PID = pid.Text;
            DataTable dt = new DataTable();
            dt = TBLL.TeacherALLBLL(st);
            s_grid.DataSource = dt;
            s_grid.DataBind();
        }


        protected void st(object sender, EventArgs e)
        {
            Response.Redirect("StudentForm.aspx");
        }

        protected void sb(object sender, EventArgs e)
        {
            Response.Redirect("SubjectForm.aspx");
        }
    }
}