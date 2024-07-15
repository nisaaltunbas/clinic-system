using System;
using Core.Abstracts.Bases;

namespace Core.Concretes.Entities.Dent
{
	public class DentistPicture:BaseEntity
	{
		public required string ImagePath { get; set; }
		public int  DentistId { get; set; }

	}
}

