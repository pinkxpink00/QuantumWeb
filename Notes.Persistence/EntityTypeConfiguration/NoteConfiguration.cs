using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Notes.Persistence.EntityTypeConfiguration
{
    // Конфігурація сутності "Note" для Entity Framework Core.
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.Id); // Встановлення первинного ключа
            builder.HasIndex(note => note.Id).IsUnique(); // Встановлення унікального індексу для Id
            builder.Property(note => note.Title).HasMaxLength(250); // Встановлення максимальної довжини для заголовку
        }
    }
}