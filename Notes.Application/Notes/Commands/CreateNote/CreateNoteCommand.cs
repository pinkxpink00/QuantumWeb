using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Application.Notes.Commands.CreateNote
{
    // Команда для створення нотатки
    public class CreateNoteCommand : IRequest<Guid>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
        public string Title { get; set; } // Заголовок нотатки
        public string Details { get; set; } // Деталі нотатки
    }
}
