using System;
namespace Core.Abstracts.Bases
{
	public abstract class BaseEntity
	{
  
        public  int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
		public bool Active { get; set; } = true;
		public bool Deleted { get; set; } = false;
	}
}

