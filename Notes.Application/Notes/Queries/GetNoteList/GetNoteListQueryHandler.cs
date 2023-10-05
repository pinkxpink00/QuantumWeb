using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Notes.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    // Обробник запиту для отримання списку нотаток
    public class GetNoteListQueryHandler : IRequestHandler<GetNoteListQuery, NoteListVm>
    {
        private readonly IMapper _mapper;
        private readonly INotesDbContext _dbContext;

        // Конструктор, приймає інтерфейс доступу до бази даних INotesDbContext та мапер AutoMapper
        public GetNoteListQueryHandler(IMapper mapper, INotesDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        // Обробка запиту на отримання списку нотаток
        public async Task<NoteListVm> Handle(GetNoteListQuery request, CancellationToken cancellationToken)
        {
            // Отримання списку нотаток з бази даних і використання AutoMapper для відображення їх у NoteLookupDto
            var notesQuery = await _dbContext.Notes
                .Where(note => note.Id == request.Id)
                .ProjectTo<NoteLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new NoteListVm { Notes = notesQuery };
        }
    }
}
