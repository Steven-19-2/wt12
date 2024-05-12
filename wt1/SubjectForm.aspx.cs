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
    public partial class SubjectForm : System.Web.UI.Page
    {
        SubjectBLL SBLL = new SubjectBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void s_inserted(object sender, EventArgs e)
        {
            subjects st = new subjects();
            st.UserId = userId.Text;
            st.Username = username.Text;
            st.Email = email.Text;
            st.Password = password.Text;
            st.Role = role.Text;

            if (SBLL.SubjectInsertBLL(st))
                status.Text = "Insert was successfull";
            else
                status.Text = "Insert was not successfull";
        }

        protected void s_updated(object sender, EventArgs e)
        {
            subjects st = new subjects();
            st.UserId = userId.Text;
            st.Username = username.Text;
            st.Email = email.Text;
            st.Password = password.Text;
            st.Role = role.Text;

            if (SBLL.SubjectUpdateBLL(st))
                status.Text = "Update was successfull";
            else
                status.Text = "Update was not successfull";
        }

        protected void s_deleted(object sender, EventArgs e)
        {
            subjects st = new subjects();
            st.UserId = userId.Text;
            st.Username = username.Text;
            st.Email = email.Text;
            st.Password = password.Text;
            st.Role = role.Text;

            if (SBLL.SubjectDeleteBLL(st))
                status.Text = "Delete was successfull";
            else
                status.Text = "Delete was not successfull";
        }

        protected void s_read(object sender, EventArgs e)
        {
            subjects st = new subjects();
            st.UserId = userId.Text;
            DataTable dt = new DataTable();
            dt = SBLL.SubjectReadBLL(st);


            if (dt.Rows.Count > 0)
            {
                status.Text = "Read was successfull";
                username.Text = dt.Rows[0]["username"].ToString();
                password.Text = dt.Rows[0]["password"].ToString();
                email.Text = dt.Rows[0]["email"].ToString();
                role.Text = dt.Rows[0]["role"].ToString();

            }

            else
                status.Text = "Read was not successfull";
        }

        protected void s_all(object sender, EventArgs e)
        {
            subjects st = new subjects();
            st.UserId = userId.Text;
            DataTable dt = new DataTable();
            dt = SBLL.SubjectALLBLL(st);
            s_grid.DataSource = dt;
            s_grid.DataBind();
        }

        protected void ts(object sender, EventArgs e)
        {
            Response.Redirect("TeacherForm.aspx");
        }

        protected void st(object sender, EventArgs e)
        {
            Response.Redirect("StudentForm.aspx");
        }
    }
}