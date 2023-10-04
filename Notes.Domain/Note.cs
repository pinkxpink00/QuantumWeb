﻿using System;

namespace Notes.Domain
{
    class Note
    {
        public Guid Id {  get; set; }
        public string Title {  get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
