using CLIReference.Infrastructure.Data.Context;
using CLIReference.Infrastructure.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CLIReference.Web.VueCoreConnection;

namespace CLIReference.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSpaStaticFiles(options => options.RootPath = "web");

            services.AddCors(options =>
            {
                options.AddPolicy(
                    "Open",
                    builder => builder.AllowAnyOrigin().AllowAnyHeader());
            });

            services.AddDbContext<CommandDbContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("CommandConnection"));
            });

            RegisterDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Open");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "/web";
                if (env.IsDevelopment())
                {
                    spa.UseVueDevelopmentServer();
                }
            });
        }

        private static void RegisterDependencies(IServiceCollection services)
        {
            DependencyAggregate.RegisterDependencies(services);
        }
    }
}
