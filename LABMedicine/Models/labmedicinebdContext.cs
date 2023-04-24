using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LABMedicine.Controllers;
using LABMedicine.Models;
using Microsoft.EntityFrameworkCore;

namespace LABMedicine.Models
{
    public class LabmedicinebdContext : DbContext
    {
        public LabmedicinebdContext(DbContextOptions<LabmedicinebdContext> options) : base(options)
        {
        }

        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<MedicoModel> Medicos { get; set; }
         public DbSet<EnfermeiroModel> Enfermeiros { get; set; }
         public DbSet<AtendimentoModel> Atendimento { get; set; }

        
    }
}