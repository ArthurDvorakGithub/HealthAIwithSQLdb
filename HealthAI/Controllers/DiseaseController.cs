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
    public class DiseaseController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DiseaseController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Disease> objList = _db.Disease.Include(u => u.CategoryOfDisease);

            return View(objList);
        }

        //GET - Upsert
        public IActionResult Upsert(int? id)
        {

            DiseaseVM diseaseVM = new DiseaseVM();
            {

                diseaseVM.Disease = new Disease();
                diseaseVM.CategoryDisSelectList = _db.CategoryOfDisease.Select(i => new SelectListItem { Text = i.Name, Value = i.Id.ToString() });

            };


            if (id == null)
            {
                //this for create 
                return View(diseaseVM);
            }
            else
            {
                diseaseVM.Disease = _db.Disease.Find(id);
                if (diseaseVM.Disease == null)
                {
                    return NotFound();
                }
                return View(diseaseVM);
            }
            return View();
        }

        //POST - Upsert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(DiseaseVM diseaseVM)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if (diseaseVM.Disease.Id == 0)
                {
                    //Create

                    string upload = webRootPath + WC.ImagePathDisease;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    diseaseVM.Disease.Image = fileName + extension;

                    _db.Disease.Add(diseaseVM.Disease);
                }
                else
                {
                    //updating
                    var objFromDb = _db.Product.AsNoTracking().FirstOrDefault(u => u.Id == diseaseVM.Disease.Id);

                    if (files.Count > 0)
                    {
                        string upload = webRootPath + WC.ImagePathDisease;
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

                        diseaseVM.Disease.Image = fileName + extension;
                    }
                    else
                    {
                        diseaseVM.Disease.Image = objFromDb.Image;
                    }
                    _db.Disease.Update(diseaseVM.Disease);


                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            diseaseVM.CategoryDisSelectList = _db.CategoryOfDisease.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            return View(diseaseVM);

        }

        // GET - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Disease disease = _db.Disease.Include(u => u.CategoryOfDisease).FirstOrDefault(u => u.Id == id);

            if (disease == null)
            {
                return NotFound();
            }

            return View(disease);
        }

        // POST - Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Disease.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            string upload = _webHostEnvironment.WebRootPath + WC.ImagePathDisease;
            var oldFile = Path.Combine(upload, obj.Image);

            if (System.IO.File.Exists(oldFile))
            {
                System.IO.File.Delete(oldFile);
            }

            _db.Disease.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }


    }
}
