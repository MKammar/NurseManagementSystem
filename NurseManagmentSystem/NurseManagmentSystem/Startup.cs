using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using NurseManagmentSystem.DAL.Contracts;
using NurseManagmentSystem.DAL.Repositories;
using NurseManagmentSystem.Data;
using NurseManagmentSystem.Infrastructure;
using NurseManagmentSystem.Models;

namespace NurseManagmentSystem
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

            services.AddControllersWithViews();

            services.AddControllers().AddNewtonsoftJson(options => 
            
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);



            services.AddRazorPages(option => {
                option.Conventions.AuthorizeFolder("/Study");
                option.Conventions.AuthorizeFolder("/Patient");
                option.Conventions.AuthorizeFolder("/Device");
            });

            

            services.AddSignalR();

            services.AddMvc();
            services.AddCors(options => options.AddPolicy("CorsPolicy",
            builder =>
            {
                builder.AllowAnyMethod().AllowAnyHeader()
                       .WithOrigins("http://localhost:44370")
                       .AllowCredentials();
            }));

            services.AddDbContext<AuthDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepositoryBase<Patient>, PatientRepository>();
            services.AddScoped<IRepositoryBase<Device>, DeviceRepository>();
            services.AddScoped<IRepositoryBase<Study>, StudyRepository>();
            services.AddScoped<IRepositoryBase<HeartRate>, HeartRateRepository>();
            services.AddScoped<IRepositoryBase<Comment>, CommentRepository>();
            services.AddScoped<IRepositoryBase<Notification>, NotificationRepository>();
            services.AddScoped<IRepositoryBase<NotificationApplicationUser>, NotificationApplicationUserRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSignalR(route => {
                route.MapHub<SignalService>("/signalServer");
            });


            app.UseEndpoints(endpoints =>
            {
              
                //endpoints.MapHub<SignalService>("/signalServer");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                ;
            });
        }
    }
}
