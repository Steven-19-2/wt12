using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;
using System.Data;

namespace BLL
{
    public class TeacherBLL
    {
        teacherDAL sbDAL = new teacherDAL();

        public bool TeacherInsertBLL(teachers s)
        {
            return sbDAL.TeacherInsertDAL(s);
        }
        public bool TeacherUpdateBLL(teachers s)
        {
            return sbDAL.TeacherUpdateDAL(s);
        }
        public bool TeacherDeleteBLL(teachers s)
        {
            return sbDAL.TeacherDeleteDAL(s);
        }
        public DataTable TeacherReadBLL(teachers s)
        {
            return sbDAL.TeacherReadDAL(s);
        }
        public DataTable TeacherALLBLL(teachers s)
        {
            return sbDAL.TeacherALLDAL(s);
        }
    }
}
