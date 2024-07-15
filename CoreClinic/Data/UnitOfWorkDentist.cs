using System;
using Core.Abstracts;
using Core.Abstracts.IRepositories;
using Core.Abstracts.IRepositories.Dent;
using Data.Contexts;
using Data.Repositories.Dent;

namespace Data
{
	public class UnitOfWorkDentist:IUnitOfWorkDentist
	{
		private readonly DentistContext dentistContext;

        public UnitOfWorkDentist(DentistContext dentistContext)
        {
            this.dentistContext = dentistContext;
        }

        private ILocationRepository? locationRepository;
        public ILocationRepository LocationRepository => locationRepository ??= new LocationRepository(dentistContext);


        public async Task CommitAsync()
        {
            try
            {
                await dentistContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                await DisposeAsync();
            }
        }

        public async ValueTask DisposeAsync()
        {
            await dentistContext.DisposeAsync();
        }
    }
}

