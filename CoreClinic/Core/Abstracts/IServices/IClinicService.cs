using System;
using System.Linq.Expressions;
using Core.Concretes.DTOs;
using Core.Concretes.Entities.Clinic;

namespace Core.Abstracts.IServices
{
    public interface IClinicService
    {
        Task<IEnumerable<PatientListItem>> GetPatientsAsync(int page = 1, int per_page = 10);
        Task<PatientDetail> GetPatientAsync(int patientId);
        Task<IEnumerable<DentistListItem>> GetDentistsAsync();

        Task CreatePatientAsync(Patient patient);

    }

   

}

