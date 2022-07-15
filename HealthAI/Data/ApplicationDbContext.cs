using HealthAI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryOfMedicament> CategoryOfMedicament { get; set; }
        public DbSet<CategoryOfDisease> CategoryOfDisease { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Disease> Disease { get; set; }
    }
}
