using System;
using System.Linq.Expressions;
using AutoMapper;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Core.Concretes.Entities.Clinic;

namespace Business.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public ClinicService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreatePatientAsync(Patient patient)
        {
            await unitOfWork.PatientRepository.CreateOneAsync(patient);
            await unitOfWork.CommitAsync();
        }


        public async Task<IEnumerable<DentistListItem>> GetDentistsAsync()
        {
            return mapper.Map<List<DentistListItem>>(await unitOfWork.DentistRepository.ReadManyAsync());
        }

        public async Task<PatientDetail> GetPatientAsync(int id)
        {
            return mapper.Map<PatientDetail>(await unitOfWork.PatientRepository.ReadOneAsync(id));
        }

        public async Task<IEnumerable<PatientListItem>> GetPatientsAsync(int page = 1, int per_page = 10)
        {
            var patient = await unitOfWork.PatientRepository.ReadManyAsync(null);
            return mapper.Map<List<PatientListItem>>(patient);
        }

    
    }


}


