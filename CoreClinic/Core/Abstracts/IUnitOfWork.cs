using System;
using Core.Abstracts.IRepositories;

namespace Core.Abstracts
{
	public interface IUnitOfWork:IAsyncDisposable
	{
	    IDentistRepository DentistRepository { get; }
		IPatientRepository PatientRepository { get; }
		IReviewRepository ReviewRepository { get; }
		IAppointmentRepository AppointmentRepository { get; }
        ITreatmentRepository TreatmentRepository { get; }
	

		Task CommitAsync();
	}
}

