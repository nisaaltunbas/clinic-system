using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Dent
{
    public class Location:BaseEntity
	{
		public required string PersonId { get; set; }
		public virtual Person? Person { get; set; }
		public required string Title { get; set; }
		public required string City { get; set; }
		public required string District { get; set; }
		public string? Street { get; set; }
		public string? Building { get; set; }
	}

}

