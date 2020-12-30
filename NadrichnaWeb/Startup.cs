using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NadrichnaWeb.Db;
using NadrichnaWeb.Profiles;
using NadrichnaWeb.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb
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

            services.AddDbContext<NadrichnaDbConext>(options => options.UseSqlServer("Server=(local);Initial Catalog=Nadrichna;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddScoped<INadrichnaDbConext, NadrichnaDbConext>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();

            var playerProfile = new PlayerProfile();
            var taskProfile = new TaskProfile();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(playerProfile);
                cfg.AddProfile(taskProfile);
            });
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
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
