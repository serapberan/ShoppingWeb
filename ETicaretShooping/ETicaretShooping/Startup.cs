using Business.Container;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using ETicaretShooping.CQRS.Handlers.ProductHandlers;
using ETicaretShooping.Models;
using ETicaretShooping.OptionsModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

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
            services.AddHttpContextAccessor();
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
            services.AddIdentity<AppUser, AppRole>(options=> 
            {
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                options.Lockout.MaxFailedAccessAttempts = 3; 
            })
                .AddEntityFrameworkStores<Context>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<CustomerIdentityValidator>();

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
            {
                opt.TokenLifespan = TimeSpan.FromHours(2); //2 gün geçerli olacak mail reset linki
            });
            services.Configure<SecurityStampValidatorOptions>(opt =>   // appuser da securitysatmp alaný 30 dk bir cookileri karþýlaþtýr (2 frklý ekrandan ayný anda girip irinde þifre gibi önemli bilgilerini yeniledi bunu diðer ekrandada görmek için yakalamalýyýz 30 dk verdik )
            {
                opt.ValidationInterval = TimeSpan.FromMinutes(30);
            });

            services.AddHttpClient(); //api istekleri karþýlama

            services.Load(); //serviceextension businessdan alýyoruz
          
            services.AddAutoMapper(typeof(Startup));

            services.MappLoad();

            services.AddHttpContextAccessor();

            services.LoginCookieLoad();

            services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Directory.GetCurrentDirectory()));
            services.AddHttpContextAccessor();
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
