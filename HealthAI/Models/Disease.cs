using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Models
{
    public class Disease
    {
        [Key]
        public int Id { get; set; }

        [Required]//атрибут анотации данных, передает данные в БД и должен быть заполнен
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contraindications { get; set; }
        public string Image { get; set; }

        [Display(Name = "Category Of Disease")]
        public int CategoryOfDiseaseId { get; set; }


        [ForeignKey("CategoryOfDiseaseId")]
        public virtual CategoryOfDisease CategoryOfDisease { get; set; }

    }
}
