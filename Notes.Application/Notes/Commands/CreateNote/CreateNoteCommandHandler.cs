using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Notes.Application.Interfaces;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.CreateNote
{
    // Обробник команди для створення нотатки
    public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, Guid>
    {
        private readonly INotesDbContext _dbContext;

        // Конструктор, приймає інтерфейс доступу до бази даних INotesDbContext
        public CreateNoteCommandHandler(INotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Обробка команди на створення нотатки
        public async Task<Guid> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            // Створення нової нотатки
            var note = new Note
            {
                Title = request.Title,
                Details = request.Details,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EditDate = null
            };

            // Додавання нотатки до контексту бази даних
            await _dbContext.Notes.AddAsync(note, cancellationToken);

            // Зберігання змін в базі даних
            await _dbContext.SaveChangesAsync(cancellationToken);

            // Повернення ідентифікатора нової нотатки
            return note.Id;
        }
    }
}

