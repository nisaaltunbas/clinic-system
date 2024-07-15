using System;
using Core.Concretes.Entities.Dent;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UI.Web
{

    public class DentistContext : IdentityDbContext<Person,PersonRole,string>
    {
        public DentistContext(DbContextOptions<DentistContext> options): base(options)
        {

        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<DentistPicture> DentistPictures { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

    }

   
}

