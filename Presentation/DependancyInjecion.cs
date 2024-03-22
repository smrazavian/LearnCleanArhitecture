using FluentValidation;

namespace Presentation
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {  
            return services;
        }
    }
}
