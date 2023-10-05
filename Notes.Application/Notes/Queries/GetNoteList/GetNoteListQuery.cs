using System;
using MediatR;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    // Запит для отримання списку нотаток
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
    }
}
