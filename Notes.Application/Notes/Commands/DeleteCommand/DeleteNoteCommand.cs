using MediatR;
using System;

namespace Notes.Application.Notes.Commands.DeleteCommand
{
    // Команда для видалення нотатки
    public class DeleteNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
    }
}

