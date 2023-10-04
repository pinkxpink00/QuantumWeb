using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence.EntityTypeConfiguration
{
    // Клас для ініціалізації бази даних. У даному випадку, метод "Initialize" просто перевіряє, чи створена база даних.
    public class DbInitialize
    {
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated(); // Перевірка і створення бази даних, якщо вона ще не існує
        }
    }
}