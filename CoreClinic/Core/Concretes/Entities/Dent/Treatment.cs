using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Dent
{
    public class Treatment:BaseEntity
    {
        public int TreatmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }

}

