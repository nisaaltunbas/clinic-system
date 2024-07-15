using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Clinic
{
    public class Patient:BaseEntity
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public  Dentist? Dentist { get; set; }
        public string DentistName { get; set; }
    }

}

