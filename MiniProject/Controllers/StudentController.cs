using MiniProjBL;
using MiniProjDTO;
using MiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProject.Controllers
{
    public class StudentController : Controller
    {
        MiniProjbl blobj;
        public StudentController()
        {
            blobj = new MiniProjbl();
        }
        // GET: Student
        public ActionResult ViewAllStudents()
        {
            List<StudentDTO> lstStudent = blobj.GetAllStudents();
            List<StudentView> lfoutcome = new List<StudentView>;
            foreach (var student in lstStudent)
            {
                lfoutcome.Add(new StudentView()
                {
                    StudentName = student.StudentName,
                    studentID = student.StudentID
                });
            }
            return View(lfoutcome);
        }
    }
}