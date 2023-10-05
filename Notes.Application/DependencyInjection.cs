using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.Application
{
    public static class DependencyInjection
    {
        // Метод розширення для налаштування залежностей Application Layer
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Додавання всіх обробників запитів та команд (MediatR)
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
