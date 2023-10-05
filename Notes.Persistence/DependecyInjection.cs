using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notes.Application.Interfaces;

namespace Notes.Persistence
{
    public static class DependencyInjection
    {
        // Метод розширення для налаштування залежностей Persistence Layer
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            // Отримання рядка підключення до бази даних з конфігурації
            var connectionString = configuration["DbConnection"];

            // Додавання контексту бази даних (NotesDbContext) у контейнер залежностей
            services.AddDbContext<NotesDbContext>(options =>
            {
                // Використання Npgsql як провайдера для PostgreSQL та передача рядка підключення
                options.UseNpgsql(connectionString);
            });

            // Додавання служби INotesDbContext, яка буде реалізована контекстом бази даних
            services.AddScoped<INotesDbContext>(provider =>
                provider.GetService<NotesDbContext>());

            return services;
        }
    }
}
