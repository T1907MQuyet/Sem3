using My_ap.net_mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_ap.net_mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        // step2
        static IList<Student> studentsList = new List<Student> { 
            new Student() {StudentId= 1 ,StudentName="Linh", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh1", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh2", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh3", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh4", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh5", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh6", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh7", Age= 20},
            new Student() {StudentId= 1 ,StudentName="Linh8", Age= 20},

        };
        public ActionResult Index()
        {// 3 steps 
            //1 . Nhan request
            //2 Call instance of model
            //3 dedirect to view

            // step3 to view
         
            return View(studentsList.OrderBy(s =>s.StudentId).ToList());
        }

        public  ActionResult Edit(Student Id)
        {
            var std = studentsList.Where(s => s.StudentId == Id).FirstOrDerfault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit( Student std)
        {
            var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            studentList.Remove(stude);
            studentList.Add(std);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public 
    }
}