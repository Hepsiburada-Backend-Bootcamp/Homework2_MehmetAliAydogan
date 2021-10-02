using ECommerce.Domain.Repositories;
using ECommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public static class InfrastructureModuleExtensions
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
