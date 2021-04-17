﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Dtos
{
    public class MovieDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int NumberInStock { get; set; }
        public byte GenreId { get; set; }

    }
}