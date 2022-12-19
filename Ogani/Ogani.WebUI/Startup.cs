using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ogani.WebUI.AppCode.Providers;
using Ogani.WebUI.Models.DataContext;

namespace Ogani.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());
            });

            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });

            services.AddDbContext<OganiDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("cString"));
                //cfg.UseMySql(Configuration.GetConnectionString("cStringMySql"));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Seed();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("defaultArea", "Admin", "admin/{controller=home}/{action=index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}

