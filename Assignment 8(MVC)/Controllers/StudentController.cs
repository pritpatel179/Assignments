using Models;
using _1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace _1.Controllers
{
        public class StudentController : Controller
    {

        public readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        private void PopulateSubjectsDropDownList (object selectedSubject = null )
        {
            var subjectsQuery = from s in _db.Teacher
                                orderby s.TName
                                select new {ID = s.TID, s.TName};

           ViewBag.ID = new SelectList(subjectsQuery.AsNoTracking(),"ID","Subject_Name",selectedSubject);

        }

        public IActionResult Index()
        {
      
            IEnumerable<Student> objList = _db.Student;
            return View(objList);
        }

        //Get Create
        public IActionResult Create()
        {
            PopulateSubjectsDropDownList(); 
            return View();
        }


        [HttpPost]
        public IActionResult Create([Bind("Name,Class,ID")] Student studobj)
        {
            if (ModelState.IsValid)
            {
                _db.Student.Add(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studobj);
        }

        //Get Create
        public IActionResult Edit(int id)
        {
            
           var  studobj = _db.Student.Find(id);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Student.Update(obj);
                _db.SaveChanges();
               return  RedirectToAction("Index");
            }
             return View(obj); 
        }

        //Get Delete
        public IActionResult Delete(int id)
        {

            var studobj = _db.Student.Find(id);
            return View(studobj);
        }


        [HttpPost]
        public IActionResult DeletePost(int studentid)
        {
            var studobj = _db.Student.Find(studentid);

            if (ModelState.IsValid)
            {

                _db.Student.Remove(studobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studobj);
        }
    }
}