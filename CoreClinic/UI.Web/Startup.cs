using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().AddRazorPagesOptions(options =>
        {
            options.Conventions.AddPageRoute("/Pages/Home", "");
        });


    }

  
}

