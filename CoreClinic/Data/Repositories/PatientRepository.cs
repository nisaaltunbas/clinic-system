using Core.Abstracts.IRepositories;
using Core.Concretes.Entities.Clinic;
using Data.Contexts;
using Utilities.Models;

namespace Data.Repositories
{
    public class PatientRepository : GenericRepository<Patient>,IPatientRepository
    {
        public PatientRepository(ClinicContext context) : base(context) { }
    }
}

