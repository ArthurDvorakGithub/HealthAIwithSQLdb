using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Models.ViewModels
{
    public class MedicamentVM
    {
        public Medicament Medicament { get;  set; }
        public IEnumerable<SelectListItem> CategoryMedSelectList { get; set; }

    }
}
