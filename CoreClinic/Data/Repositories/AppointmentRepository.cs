using Core.Abstracts.IRepositories;
using Core.Concretes.Entities.Clinic;
using Data.Contexts;
using Utilities.Models;

namespace Data.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>,IAppointmentRepository
    {
        public AppointmentRepository(ClinicContext context) : base(context) { }
    }
}

