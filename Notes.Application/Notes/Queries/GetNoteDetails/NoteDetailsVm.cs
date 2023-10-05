using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    // ViewModel для відображення деталей нотатки
    public class NoteDetailsVm : IMapWith<Note>
    {
        public Guid Id { get; set; } // Ідентифікатор нотатки
        public string Title { get; set; } // Заголовок нотатки
        public string Details { get; set; } // Деталі нотатки
        public DateTime CreationDate { get; set; } // Дата створення
        public DateTime? EditDate { get; set; } // Дата останнього редагування

        // Метод для виконання мапінгу
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.CreationDate,
                opt => opt.MapFrom(note => note.CreationDate))
                .ForMember(noteVm => noteVm.EditDate,
                opt => opt.MapFrom(note => note.EditDate));
        }
    }
}
