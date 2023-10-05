﻿using System;
using AutoMapper;
using Notes.Domain;
using Notes.Application.Common.Mappings;
using MediatR;
using System.Reflection;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details {  get; set; }
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
