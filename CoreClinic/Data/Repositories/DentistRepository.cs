using System;
using Core.Abstracts.IRepositories;
using Core.Concretes.Entities.Clinic;
using Data.Contexts;
using Utilities.Models;

namespace Data.Repositories
{
    public class DentistRepository : GenericRepository<Dentist>,IDentistRepository
    {
        public DentistRepository(ClinicContext context) : base(context) { }
    }
}

