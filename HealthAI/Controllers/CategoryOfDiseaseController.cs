using HealthAI.Data;
using HealthAI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Controllers
{
    public class CategoryOfDiseaseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryOfDiseaseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryOfDisease> objList = _db.CategoryOfDisease;
            return View(objList);
        }

        // GET - Create
        public IActionResult Create()
        {
            return View();
        }

        // POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryOfDisease obj)
        {
            if (ModelState.IsValid)// валидация на стороне сервера
            {
                _db.CategoryOfDisease.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        // GET - Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.CategoryOfDisease.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryOfDisease obj)
        {
            if (ModelState.IsValid)
            {
                _db.CategoryOfDisease.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        // GET - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.CategoryOfDisease.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.CategoryOfDisease.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.CategoryOfDisease.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }


    }
}
