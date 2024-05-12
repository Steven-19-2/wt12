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
    public class SubjectBLL
    {
        subjectDAL sbDAL = new subjectDAL();

        public bool SubjectInsertBLL(subjects s)
        {
            return sbDAL.SubjectInsertDAL(s);
        }
        public bool SubjectUpdateBLL(subjects s)
        {
            return sbDAL.SubjectUpdateDAL(s);
        }
        public bool SubjectDeleteBLL(subjects s)
        {
            return sbDAL.SubjectDeleteDAL(s);
        }

        public DataTable SubjectReadBLL(subjects s)
        {
            return sbDAL.SubjectReadDAL(s);
        }

        public DataTable SubjectALLBLL(subjects s)
        {
            return sbDAL.SubjectALLDAL(s);
        }
    }
}
