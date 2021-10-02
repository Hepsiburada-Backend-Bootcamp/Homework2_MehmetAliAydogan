using AutoMapper.Extensions.ExpressionMapping;
using Ecommerce.Application.Categories;
using ECommerce.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application
{
    public static class ApplicationModuleExtensions
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => {
                cfg.AddExpressionMapping();
                }, Assembly.GetExecutingAssembly());

            services.AddInfrastructureModule();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
