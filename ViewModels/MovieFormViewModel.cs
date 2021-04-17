using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTutorial.Models;

namespace VidlyTutorial.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }
        public string Name { get; set;}
        public byte? GenreId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int NumberInStock { get; set; }
        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Movie Form";

                return "Movie Form";
            }
        }

        public MovieFormViewModel()
        {

        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;

        }


    }

}





