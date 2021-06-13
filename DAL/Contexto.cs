using Prestamos_Detalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace Prestamos_Detalle.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Pretamos> Prestamos { get; set; }
        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data\Prestamo.db");
        }
    }
}
