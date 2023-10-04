using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Notes.Persistence.EntityTypeConfiguration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> buider)
        {
            buider.HasKey(note => note.Id);
            buider.HasIndex(note => note.Id).IsUnique();
            buider.Property(note => note.Title).HasMaxLength(250);
        }
    }
}
