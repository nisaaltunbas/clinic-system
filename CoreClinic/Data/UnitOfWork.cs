using System;
using Core.Abstracts;
using Core.Abstracts.IRepositories;
using Data.Contexts;
using Data.Repositories;

namespace Data
{
	public class UnitOfWork:IUnitOfWork
	{
		private readonly ClinicContext clinicContext;

        public UnitOfWork(ClinicContext clinicContext)
        {
            this.clinicContext = clinicContext;
        }
        private IDentistRepository? dentistRepository;
        public IDentistRepository DentistRepository => dentistRepository ??= new DentistRepository(clinicContext);

        private IPatientRepository patientRepository;
        public IPatientRepository PatientRepository => patientRepository ??= new PatientRepository(clinicContext);

        private IReviewRepository reviewRepository;
        public IReviewRepository ReviewRepository => reviewRepository ??= new ReviewRepository(clinicContext);

        private IAppointmentRepository appointmentRepository;
        public IAppointmentRepository AppointmentRepository => appointmentRepository ??= new AppointmentRepository(clinicContext);

        private ITreatmentRepository treatmentRepository;
        public ITreatmentRepository TreatmentRepository => treatmentRepository ??= new TreatmentRepository(clinicContext);

        public async Task CommitAsync()
        {
            try
            {
                await clinicContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                await DisposeAsync();
            }
            
        }

        public async ValueTask DisposeAsync()
        {
            await clinicContext.DisposeAsync();
        }
    }
}

