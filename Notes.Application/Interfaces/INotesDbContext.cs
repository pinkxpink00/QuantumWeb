using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Interfaces
{
    // Інтерфейс для доступу до бази даних записів.
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; } // DbSet для роботи з записами
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); // Асинхронне збереження змін у базі даних
    }
}