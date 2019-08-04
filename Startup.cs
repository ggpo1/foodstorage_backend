using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.ApartmentSevice;
using FoodStorage_Backend.Services.TestService;
using FoodStorage_Backend.Services.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FoodStorage_Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            MyDb.db.Users.RemoveRange(MyDb.db.Users.ToArray());
            MyDb.db.Apartments.RemoveRange(MyDb.db.Apartments.ToArray());
            MyDb.db.SaveChanges();

            User user1 = new User() { UserName = "user1", UserEmail = "user@email.com" };
            MyDb.db.Users.Add(user1);
            MyDb.db.SaveChanges();

            Apartment apartment1 = new Apartment() { ApartmentName = "Дом", ApartmentAddress = "Москва", UserID = MyDb.db.Users.First(elem => elem.UserName == user1.UserName).UserID };
            MyDb.db.Apartments.Add(apartment1);
            MyDb.db.SaveChanges();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Services Registrations
            services.AddScoped<ITestService, TestService>(); // tests service
            services.AddScoped<IApartmentService, ApartmentService>(); // apartments service
            services.AddScoped<IUserService, UserService>(); // users service

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
