using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FacultyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Faculty> objList = _db.Facultys;
            return View(objList);
           
        }

        //get create
        public IActionResult Create()
        {
            return View();
        }

        //post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Faculty obj)
        {
            if (ModelState.IsValid)
            {
                _db.Facultys.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Facultys.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Facultys.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Facultys.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        //get update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Facultys.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //post update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Faculty obj)
        {
            if (ModelState.IsValid)
            {
                _db.Facultys.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
