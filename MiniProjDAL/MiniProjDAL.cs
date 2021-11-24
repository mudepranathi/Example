using MiniProjDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MiniProjDAL
{
    public class MiniProjdal
    {
        MiniProjContext cntxobj;
        SqlConnection sqlcon;
        SqlCommand sqlcomm;

       
        public MiniProjdal()
        {
            sqlcon = new SqlConnection();
            sqlcomm = new SqlCommand();
            cntxobj = new MiniProjContext();
        }
       
        public List<StudentDTO> FetchAllStudents()
        {
            try
            {
                sqlcon.ConnectionString = ConfigurationManager.ConnectionStrings["StudentInfo"].ConnectionString;
                sqlcomm.CommandText = @"select [StudentID],[StudentName],[CourseID],[TeacherID] from [MiniProject].[Student]";
                sqlcomm.CommandType = System.Data.CommandType.Text;
                sqlcomm.Connection = sqlcon;
                SqlDataAdapter sqldaobj = new SqlDataAdapter();
                sqldaobj.SelectCommand = sqlcomm; 
                DataTable dtobj = new DataTable();
                sqldaobj.Fill(dtobj);
                List<StudentDTO> lstudent = new List<StudentDTO>();
                foreach(DataRow student in dtobj.Rows)
                {
                    StudentDTO dtoobj = new StudentDTO();
                    dtoobj.StudentID = Convert.ToInt32(student["StudentID"]);
                    dtoobj.StudentName = student["Student_Name"].ToString();
                    dtoobj.CourseID = Convert.ToInt32(student["Course_ID"]);
                    dtoobj.TeacherID = Convert.ToInt32(student["Teacher_ID"]);
                    lstudent.Add(dtoobj);

                }
                return lstudent;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
