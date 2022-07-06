using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Models.ViewModels
{
    public class DiseaseVM
    {
        public Disease Disease { get; set; }
        public IEnumerable<SelectListItem> CategoryDisSelectList { get; set; }
    }
}
