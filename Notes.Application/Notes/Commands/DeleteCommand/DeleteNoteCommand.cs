﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Commands.DeleteCommand
{
    public class DeleteNoteCommand : IRequest<Unit>
    {
        public Guid Id { get; set; } 
    }
}