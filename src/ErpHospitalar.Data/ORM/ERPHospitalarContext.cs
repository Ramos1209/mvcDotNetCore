using ErpHospitalar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ErpHospitalar.Data.ORM
{
   public class ERPHospitalarContext: DbContext
    {
        public ERPHospitalarContext(DbContextOptions<ERPHospitalarContext> options) : base(options)
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<EstadoPaciente> EstadoPaciente { get; set; }
    }
}
