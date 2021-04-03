using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> student = new List<Student>();
            student.Add(new Student { StudentName="Mohammad",StudentId=2});
            
            return View(student.AsEnumerable());
        }

     
    }
}