﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Models
{
    public class Movie
    {
        public byte Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime? ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 25)]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
        
        public Genre Genre { get; set; }
        
        public byte GenreId { get; set; }
    }
}