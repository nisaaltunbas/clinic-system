using Core.Concretes.Entities.Clinic;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {
        }

       


        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dentist>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Patient>()
                .HasKey(p => p.Id);
        }




    }

}

