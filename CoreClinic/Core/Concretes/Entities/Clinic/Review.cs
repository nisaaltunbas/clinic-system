using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Clinic
{
    public class Review:BaseEntity
    {
        //public int DentistId { get; set; }
        public string ReviewerName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // Rating out of 5
        public DateTime DatePosted { get; set; }
        // Other properties as needed
        public Dentist Dentist { get; set; }
        public Appointment Appointment { get; set; } // Optional navigation property
    }

}

