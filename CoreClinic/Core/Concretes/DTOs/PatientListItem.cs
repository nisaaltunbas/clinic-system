using Core.Concretes.Entities.Clinic;
using System;
namespace Core.Concretes.DTOs
{
    public class PatientListItem {
        public required int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public string Appointment { get; set; }
        public Dentist? Dentist { get; set; }
        public string DentistName { get; set; }
    }
	public class PatientDetail {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Date { get; set; }
        public Dentist DentistDetail { get; set; }
       

        public string DentistName { get; set; }
    }

    public class DentistDetail
    {
        public required int Id { get; set; }
        public string? ProfilePicture { get; set; }
        public required string DentistName { get; set; }
        public string Social { get; set; }
        public string Specialization { get; set; }
        public string About  { get; set; }
        public string ClinicName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public IEnumerable<ReviewItem>? Reviews { get; set; }

    }

    public class AppointmentListItem
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public bool IsEmergency { get; set; }
    }
    public class Contact {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }

    public class ReviewItem
    {
        public required string PatientId { get; set; }
        public int Rating { get; set; }
        public required string Comment { get; set; }
        public DateTime Date { get; set; }
    }
	
}

