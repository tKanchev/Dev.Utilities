using Dev.Utilities.Guids.Services.Guids;
using Dev.Utilities.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dev.Utilities.Guids
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
            => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddCors()
                .AddTransient<IGuidService, GuidService>()
                .AddControllers();
        

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app.UseDefaultConfiguration(env);
    }
}
