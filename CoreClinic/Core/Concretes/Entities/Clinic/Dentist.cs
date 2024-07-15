using System;
using System.ComponentModel.DataAnnotations;
using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Clinic
{
    public class Dentist:BaseEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? ProfilePicture { get; set; }
        public string ContactInfo { get; set; }
        public string Specialization { get; set; }
        public required string About { get; set; }
        public string Social { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; } = new HashSet<Patient>();

    }

}

