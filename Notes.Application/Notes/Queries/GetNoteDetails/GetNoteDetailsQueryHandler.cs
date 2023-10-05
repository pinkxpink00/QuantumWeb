using AutoMapper;
using Notes.Application.Interfaces;
using MediatR;
using Notes.Application.Common.Exceptions;
using Notes.Domain;
using Microsoft.EntityFrameworkCore;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    // Обробник запиту для отримання деталей нотатки
    public class GetNoteDetailsQueryHandler : IRequestHandler<GetNoteDetailsQuery, NoteDetailsVm>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;

        // Конструктор, приймає інтерфейс доступу до бази даних INotesDbContext та мапер AutoMapper
        public GetNoteDetailsQueryHandler(INotesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // Обробка запиту на отримання деталей нотатки
        public async Task<NoteDetailsVm> Handle(GetNoteDetailsQuery request, CancellationToken cancellationToken)
        {
            // Пошук нотатки за ідентифікатором
            var entity = await _dbContext.Notes.FirstOrDefaultAsync(note =>
            note.Id == request.Id, cancellationToken);

            // Якщо нотатку не знайдено, викидаємо виняток NotFoundException
            if (entity == null)
            {
                throw new NotFoundException(nameof(Note), request.Id);
            }

            // Повертаємо деталі нотатки, використовуючи AutoMapper
            return _mapper.Map<NoteDetailsVm>(entity);
        }
    }
}
