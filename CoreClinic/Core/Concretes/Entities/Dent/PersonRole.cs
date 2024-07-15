using Microsoft.AspNetCore.Identity;

namespace Core.Concretes.Entities.Dent
{
    public class PersonRole : IdentityRole
	{
		public string? Description { get; set; }
	}

}

