using System;
using AutoMapper;
using Notes.Domain;
using Notes.Application.Common.Mappings;
using MediatR;
using System.Reflection;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    // ViewModel для списку нотаток
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
        public string Title { get; set; } // Заголовок нотатки
        public string Details { get; set; } // Деталі нотатки

        // Метод для виконання мапінгу
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteDto => noteDto.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteDto => noteDto.Details,
                opt => opt.MapFrom(note => note.Details));
        }
    }
}
