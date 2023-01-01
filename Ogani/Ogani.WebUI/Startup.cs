using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ogani.WebUI.AppCode.Providers;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity.Membership;

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

                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            });


            services.AddDbContext<OganiDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("cString"));
                //cfg.UseMySql(Configuration.GetConnectionString("cStringMySql"));
            });

            services.AddIdentity<OganiUser, OganiRole>()
                .AddEntityFrameworkStores<OganiDbContext>();

            services.AddScoped<SignInManager<OganiUser>>();
            services.AddScoped<UserManager<OganiUser>>();
            services.AddScoped<RoleManager<OganiRole>>();

            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });

            services.AddAuthentication();
            services.AddAuthorization(cfg =>
            {
                cfg.AddPolicy("admin.blogCategories.index", p =>
                {
                    p.RequireAssertion(handler =>
                    {
                        bool allow = handler.User.IsInRole("SuperAdmin")
                        || handler.User.HasClaim(m => m.Type.Equals("admin.blogCategories.index") && m.Value.Equals("1"));

                        return allow;
                    });
                });
                //cfg.AddPolicy("admin.blogCategories.details", p =>
                //{
                //    p.RequireAssertion(handler =>
                //    {
                //        bool allow = handler.User.IsInRole("SuperAdmin")
                //        || handler.User.HasClaim(m => m.Type.Equals("admin.blogCategories.details") && m.Value.Equals("1"));

                //        return allow;
                //    });
                //});
                cfg.AddPolicy("admin.blogCategories.create", p =>
                {
                    p.RequireAssertion(handler =>
                    {
                        bool allow = handler.User.IsInRole("SuperAdmin")
                        || handler.User.HasClaim(m => m.Type.Equals("admin.blogCategories.create") && m.Value.Equals("1"));

                        return allow;
                    });
                });
                cfg.AddPolicy("admin.blogCategories.edit", p =>
                {
                    p.RequireAssertion(handler =>
                    {
                        bool allow = handler.User.IsInRole("SuperAdmin")
                        || handler.User.HasClaim(m => m.Type.Equals("admin.blogCategories.edit") && m.Value.Equals("1"));

                        return allow;
                    });
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Seed()
                .SeedMembership();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("defaultArea", "Admin", "admin/{controller=home}/{action=index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}

