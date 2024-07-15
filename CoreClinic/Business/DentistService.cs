using Business.Services;
using Core.Abstracts;
using Core.Abstracts.IServices;
using Core.Concretes.Entities.Dent;
using Data;
using Data.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class DentistService
{
    public static IServiceCollection AddBusinessServices(this
        IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<DentistContext>(opt=>opt.UseSqlite(configuration.GetConnectionString("dentist")));

        services.AddIdentity<Person, PersonRole>()
            .AddEntityFrameworkStores<DentistContext>()
            .AddDefaultTokenProviders();
     

        services.AddDbContext<ClinicContext>(opt=>opt.UseSqlite(configuration.GetConnectionString("clinic")));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUnitOfWorkDentist, UnitOfWorkDentist>();

        services.AddScoped<IClinicService,ClinicService>();

        
        return services;
    }
}

