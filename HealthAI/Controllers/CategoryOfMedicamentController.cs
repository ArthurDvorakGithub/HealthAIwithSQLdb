using HealthAI.Data;
using HealthAI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Controllers
{
    public class CategoryOfMedicamentController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryOfMedicamentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryOfMedicament> objList = _db.CategoryOfMedicament;
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
        public IActionResult Create(CategoryOfMedicament obj)
        {
            if (ModelState.IsValid)
            {
                _db.CategoryOfMedicament.Add(obj);
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

            var obj = _db.CategoryOfMedicament.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        // POST - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryOfMedicament obj)
        {
            if (ModelState.IsValid)
            {
                _db.CategoryOfMedicament.Update(obj);
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

            var obj = _db.CategoryOfMedicament.Find(id);

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
            var obj = _db.CategoryOfMedicament.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.CategoryOfMedicament.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
