using System;

namespace Notes.Application.Common.Exceptions
{
    // Власний виняток для випадків, коли сутність не знайдена
    internal class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"Entity\"{name}\" ({key})not found.") { }
    }
}
