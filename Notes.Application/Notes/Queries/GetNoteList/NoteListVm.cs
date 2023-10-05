using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    // ViewModel для списку нотаток
    public class NoteListVm
    {
        public IList<NoteLookupDto> Notes { get; set; } // Список нотаток
    }
}
