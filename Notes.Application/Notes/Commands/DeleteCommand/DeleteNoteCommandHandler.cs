using MediatR;
using Notes.Application.Interfaces;
using Notes.Application.Common.Exceptions;
using Notes.Domain;

namespace Notes.Application.Notes.Commands.DeleteCommand
{
    // Обробник команди видалення нотатки
    public class DeleteNoteCommandHandler : IRequestHandler<DeleteNoteCommand, Unit>
    {
        private readonly INotesDbContext _dbContext;

        // Конструктор, приймає інтерфейс доступу до бази даних INotesDbContext
        public DeleteNoteCommandHandler(INotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Обробка команди на видалення
        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            // Пошук нотатки за ідентифікатором
            var entity = await _dbContext.Notes.FindAsync(new object[] { request.Id }, cancellationToken);

            // Якщо нотатку не знайдено, викидаємо виняток NotFoundException
            if (entity == null)
            {
                throw new NotFoundException(nameof(Note), request.Id);
            }

            // Видаляємо нотатку з контексту бази даних
            _dbContext.Notes.Remove(entity);

            // Зберігаємо зміни в базі даних
            await _dbContext.SaveChangesAsync(cancellationToken);

            // Повертаємо Unit (зазвичай використовується, коли результат команди не має значення)
            return Unit.Value;
        }
    }
}
