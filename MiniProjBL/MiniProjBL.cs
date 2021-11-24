using MiniProjDAL;
using MiniProjDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjBL
{
    public class MiniProjbl
    {
        MiniProjdal dalobj;
        public MiniProjbl()
        {
            dalobj = new MiniProjdal();
        }
        public List<StudentDTO> GetAllStudents()
        {
            try
            {
                List<StudentDTO> lfstudent = dalobj.FetchAllStudents();
                return lfstudent;
            }
            catch(Exception )
            {
                throw;
            }
            
        }
        /*
        public int AddNewStudent(StudentDTO newstobj)
        {
            try
            {
                int val = dalobj.InsertNewStudent(newstobj);
                return val;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }*/
    }
}
