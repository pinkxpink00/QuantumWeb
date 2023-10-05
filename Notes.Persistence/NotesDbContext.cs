using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using Notes.Application.Interfaces;
using Notes.Persistence.EntityTypeConfiguration;

namespace Notes.Persistence
{
    // Клас, який реалізує інтерфейс INotesDbContext і представляє контекст бази даних записів.
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; } // DbSet для роботи з записами

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration()); // Застосування конфігурації для сутності "Note"
            base.OnModelCreating(builder);
        }
    }
}