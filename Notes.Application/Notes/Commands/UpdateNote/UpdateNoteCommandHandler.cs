using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using Notes.Application.Common.Exceptions;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    // Обробник команди для оновлення нотатки
    public class UpdateNoteCommandHandler : IRequestHandler<UpdateNoteCommand, Unit>
    {
        private readonly INotesDbContext _dbContext;

        // Конструктор, приймає інтерфейс доступу до бази даних INotesDbContext
        public UpdateNoteCommandHandler(INotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Обробка команди на оновлення нотатки
        public async Task<Unit> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
            // Пошук нотатки за ідентифікатором
            var entity = await _dbContext.Notes.FirstOrDefaultAsync(note => note.Id == request.Id, cancellationToken);

            // Якщо нотатку не знайдено, викидаємо виняток NotFoundException
            if (entity == null)
            {
                throw new NotFoundException(nameof(Note), request.Id);
            }

            // Оновлення даних нотатки
            entity.Details = request.Details;
            entity.Title = request.Title;
            entity.EditDate = DateTime.Now;

            // Зберігання змін в базі даних
            await _dbContext.SaveChangesAsync(cancellationToken);

            // Повернення Unit (зазвичай використовується, коли результат команди не має значення)
            return Unit.Value;
        }
    }
}
