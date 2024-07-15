using System;
using System.Net;
using Microsoft.AspNetCore.Identity;

namespace Core.Concretes.Entities.Dent
{
    public class Person:IdentityUser
	{
		public required string FirstName { get; set; }
		public required string LastName { get; set; }
		public required string ProfilePicture { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public virtual ICollection<Location>? Locations { get; set; } = new HashSet<Location>();
        public ICollection<Appointment> Appointments { get; set; }
    }

}

