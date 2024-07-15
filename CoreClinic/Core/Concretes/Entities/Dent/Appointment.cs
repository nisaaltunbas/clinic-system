using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Dent
{
    public class Appointment:BaseEntity
    {
        public int AppointmentId { get; set; }
        public int PersonId { get; set; }
        public int DentistId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public Person Person { get; set; }
    }

}

