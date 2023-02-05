using Business.Container;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using DTO.DTOs.NotificationDTOs;
using Entities.Concrete;
using ETicaretShooping.CQRS.Handlers.ProductHandlers;
using ETicaretShooping.Models;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Xml.Linq;

namespace ETicaretShooping
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
            services.AddScoped<GetAllProductQueryHandler>();
            services.AddScoped<GetByIdProductQueryHandler>();
            services.AddScoped<CreateProductCommandHanler>();
            services.AddScoped<DeleteProductCommandHandler>();
            services.AddScoped<UpdateProductCommandHandler>();

            services.AddMediatR(typeof(Startup));

            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
            });

            services.AddDbContext<Context>();  //register iþlemleri için
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomerIdentityValidator>();

            services.AddHttpClient(); //api istekleri karþýlama

            services.Load(); //serviceextension businessdan alýyoruz

            services.AddAutoMapper(typeof(Startup));

            services.MappLoad();

            services.AddHttpContextAccessor();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Identity/Account/Login";
                options.LogoutPath = "/Identity/Account/Logout";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            });


            

            services.AddControllersWithViews();
           
            services.AddMvc(config =>    //proje seviyesinde auth olunacak
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logger\\Log.txt");

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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });

            app.UseEndpoints(endpoints =>   //Areas için 
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>   //Areas için 
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
