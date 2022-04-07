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
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }
        // for using second index method
        // public IActionResult Index()
        // {
        //     IEnumerable<Teacher> listofTName = _db.Teacher;

        //     return View(listofTName);
        // }
            public async Task<IActionResult> Index(string SearchString)
            {
                // IEnumerable<Teacher> listofTName = _db.Teacher;

                var teachers = from t in _db.Teacher
                               select t;
                if (!String.IsNullOrEmpty(SearchString))
                {
                    teachers = teachers.Where(s => s.TName!.Contains(SearchString));
                }

                return View(await teachers.ToListAsync());
            // return View(listofTName);

            }
        //Get create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher obj)
        {
            if (ModelState.IsValid)
            {
                _db.Teacher.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit(int subjectid)
        {
            var subobj = _db.Teacher.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult Edit(Teacher updatedvaluesobj)
        {
            _db.Teacher.Update(updatedvaluesobj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult Delete(int subjectid)
        {
            var subobj = _db.Teacher.Find(subjectid);
            return View(subobj);

        }

        [HttpPost]
        public IActionResult DeletePost(int TID)
        {
            var subobj = _db.Teacher.Find(TID);

            if (ModelState.IsValid)
            {
                _db.Teacher.Remove(subobj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subobj);

        }


    }
}