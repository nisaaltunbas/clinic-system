using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Clinic
{
    public class Appointment:BaseEntity
    {
        //public int DentistId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string? Notes { get; set; }
    }

}

