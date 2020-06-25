using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplyApp.Repository;
using ApplyApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ApplyMVC
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
            services.AddDbContext<CrmDbContext>(options =>
               options.UseSqlServer(CrmDbContext.connectionString));

            services.AddTransient<ISkillManagement, SkillManagement>();
            services.AddTransient<IRequestManagement, RequestManagement>();
            services.AddTransient<IJobOfferManagement, JobOfferManagement>();
            services.AddTransient<IHRManagerManagement, HRManagerManagement>();
            services.AddTransient<IExperienceManagement, ExperienceManagement>();
            services.AddTransient<IEducationManagement, EducationManagement>();
            services.AddTransient<ICandidateManagement, CandidateManagement>();


            services.AddControllersWithViews();
            services.AddLogging();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
