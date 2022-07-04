using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Models
{
    public class Medicament
    {
        [Key]
        public int Id { get; set; }
        [Required]//атрибут анотации данных, передает данные в БД и должен быть заполнен
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string CodATC { get; set; }
        public string Image { get; set; }

        [Display(Name = "Category Of Medicament")]
        public int CategoryOfMedicamentId { get; set; }

        
        [ForeignKey("CategoryOfMedicamentId")]
        public virtual CategoryOfMedicament CategoryOfMedicament { get; set; }


    }
}
