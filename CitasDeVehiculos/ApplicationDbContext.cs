using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasDeVehiculos.Entidades;


namespace CitasDeVehiculos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Citas> Citas { get; set; }
        public DbSet<Estado> Estado { get; set; }
    }
}
