using System;
using Core.Abstracts.IRepositories.Dent;
using Core.Concretes.Entities.Dent;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Utilities.Models;

namespace Data.Repositories.Dent
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(DentistContext context) : base(context)
        {
        }
    }
}

