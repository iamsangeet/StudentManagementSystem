using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    public class BatchController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BatchController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Batch> objList = _db.Batchs;
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
        public IActionResult Create(Batch obj)
        {
            if (ModelState.IsValid)
            {
                _db.Batchs.Add(obj);
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
            var obj = _db.Batchs.Find(id);
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
            var obj = _db.Batchs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Batchs.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        //get update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Batchs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //post update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Batch obj)
        {
            if (ModelState.IsValid)
            {
                _db.Batchs.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
