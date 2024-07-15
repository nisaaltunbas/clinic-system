using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Clinic
{
    public class Treatment:BaseEntity
    {
        public int PatientId { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public Patient? Patient { get; set; }
    }

}

