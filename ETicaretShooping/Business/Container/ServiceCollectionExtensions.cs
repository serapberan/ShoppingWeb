using Business.Abstract;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DTO.DTOs.NotificationDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();
           
        }

        public static void MappLoad(this IServiceCollection services)
        {
            services.AddTransient<IValidator<NotificationAddDto>, NotificationValidation>();
      
        }
    }
}
