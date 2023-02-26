using Business.Abstract;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DTO.DTOs.NotificationDTOs;
using Entities.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace Business.Container
{
    public static class ServiceCollectionExtensions
    {
        public static void Load(this IServiceCollection services)
        {

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IAppRoleService, AppRoleManager>();
            services.AddScoped<IAppRoleDal, EfAppRoleDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<INotificationsService, NotificationsManager>();
            services.AddScoped<INotificationsDal, EfNotificationsDal>();

            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICartDal, EfCartDal>();

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();
          

        }

        public static void MappLoad(this IServiceCollection services)
        {
            services.AddTransient<IValidator<NotificationAddDto>, NotificationValidation>();

        }


        public static void LoginCookieLoad(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
                {
                    var cookieBuilder = new CookieBuilder();
                    cookieBuilder.Name = "EShoppingCookie";
                    options.LoginPath = "/Login/SignIn";
                    options.LogoutPath = "/Anasayfa/Index";
                    options.AccessDeniedPath = "/AuthorizationPage/AccessDenied";
                    options.Cookie = cookieBuilder;
                    options.ExpireTimeSpan = TimeSpan.FromDays(60); //60 gün tut
                options.SlidingExpiration = true;  // 60 gün dolduktan sonra tekrar giriş yaparsa tekrar 60 günü uzat

            });
        }
    }
}