using System;
using Core.Abstracts.IRepositories;
using Core.Abstracts.IRepositories.Dent;

namespace Core.Abstracts
{
	public interface IUnitOfWorkDentist:IAsyncDisposable
	{
		ILocationRepository LocationRepository { get; }
	

		Task CommitAsync();
	}
}

