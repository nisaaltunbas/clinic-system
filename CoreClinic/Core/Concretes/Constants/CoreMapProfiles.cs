using System;
using AutoMapper;
using Core.Concretes.DTOs;
using Core.Concretes.Entities.Clinic;

namespace Core.Concretes.Constants
{
    public class CoreMapProfiles : Profile
    {
        public CoreMapProfiles()
        {

            CreateMap<Patient, PatientDetail>()
                .ForMember(dest => dest.DentistName ,opt => opt.MapFrom(src => src.Dentist.Name));
            CreateMap<Patient, PatientListItem>()
                .ForMember(dest => dest.Dentist, opt => opt.MapFrom(src => src.Dentist.Name));

            CreateMap<Dentist, DentistListItem>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

          
        }

       
    }
    
}
 
    

