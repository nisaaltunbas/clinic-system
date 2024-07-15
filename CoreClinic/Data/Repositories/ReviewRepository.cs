using Core.Abstracts.IRepositories;
using Core.Concretes.Entities.Clinic;
using Data.Contexts;
using Utilities.Models;

namespace Data.Repositories
{
    public class ReviewRepository : GenericRepository<Review>,IReviewRepository
    {
        public ReviewRepository(ClinicContext context) : base(context) { }
    }
}

