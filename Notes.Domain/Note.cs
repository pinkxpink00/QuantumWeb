using System;

namespace Notes.Domain
{
    // Клас "Note" представляє запис у блокноті.
    public class Note
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор запису
        public string Title { get; set; } // Заголовок запису
        public string Details { get; set; } // Деталі запису
        public DateTime CreationDate { get; set; } // Дата створення запису
        public DateTime EditDate { get; set; } // Дата останньої редагування запису
    }
}
