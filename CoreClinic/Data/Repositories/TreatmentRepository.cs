using Core.Abstracts.IRepositories;
using Core.Concretes.Entities.Clinic;
using Data.Contexts;
using Utilities.Models;

namespace Data.Repositories
{
    public class TreatmentRepository : GenericRepository<Treatment>,ITreatmentRepository
    {
        public TreatmentRepository(ClinicContext context) : base(context) { }
    }
}

