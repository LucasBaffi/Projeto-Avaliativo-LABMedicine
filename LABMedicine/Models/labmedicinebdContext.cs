using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Controllers;
using Microsoft.EntityFrameworkCore;

namespace LABMedicine.Model
{
    public class labmedicinebdContext : DbContext
    {
        public labmedicinebdContext(DbContextOptions<labmedicinebdContext> options) : base(options)
        {
        }

        // public DbSet<Paciente> Pacientes { get; set; }
    }
}