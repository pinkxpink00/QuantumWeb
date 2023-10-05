using System;
using MediatR;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    // Команда для оновлення нотатки
    public class UpdateNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
        public string Title { get; set; } // Заголовок нотатки
        public string Details { get; set; } // Деталі нотатки
    }
}
