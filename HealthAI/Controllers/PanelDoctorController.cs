using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Controllers
{
    public class PanelDoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
