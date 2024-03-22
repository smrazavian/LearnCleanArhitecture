using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependancyInjection).Assembly;
            services.AddMediatR(configuration=>configuration.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
