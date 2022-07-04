using HealthAI.Data;
using HealthAI.Models;
using HealthAI.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Controllers
{
    public class MedicamentController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MedicamentController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Medicament> objList = _db.Medicament.Include(u => u.CategoryOfMedicament);
            
            return View(objList);
        }

        //GET - Upsert
        public IActionResult Upsert(int? id)
        {

            MedicamentVM medicamentVM = new MedicamentVM();
            {

                medicamentVM.Medicament = new Medicament();
                medicamentVM.CategoryMedSelectList = _db.CategoryOfMedicament.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() });
                
            };


            if (id == null)
            {
                //this for create 
                return View(medicamentVM);
            }
            else
            {
                medicamentVM.Medicament = _db.Medicament.Find(id);
                if(medicamentVM.Medicament == null)
                {
                    return NotFound();
                }
                return View(medicamentVM);
            }
            return View();
        }

        //POST - Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(MedicamentVM medicamentVM)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if(medicamentVM.Medicament.Id == 0)
                {
                    //Create
                    
                    string upload = webRootPath + WC.ImagePathMedicamnet;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    medicamentVM.Medicament.Image = fileName + extension;
                    _db.Medicament.Add(medicamentVM.Medicament);
                }
                else
                {
                    //updating
                    var objFromDb = _db.Product.AsNoTracking().FirstOrDefault(u => u.Id == medicamentVM.Medicament.Id);

                    if (files.Count > 0)
                    {
                        string upload = webRootPath + WC.ImagePathMedicamnet;
                        string fileName = Guid.NewGuid().ToString();
                        string extension = Path.GetExtension(files[0].FileName);

                        var oldFile = Path.Combine(upload, objFromDb.Image);

                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }

                        using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        medicamentVM.Medicament.Image = fileName + extension;
                    }
                    else
                    {
                        medicamentVM.Medicament.Image = objFromDb.Image;
                    }
                    _db.Medicament.Update(medicamentVM.Medicament);


                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            medicamentVM.CategoryMedSelectList = _db.CategoryOfMedicament.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            return View(medicamentVM);

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
