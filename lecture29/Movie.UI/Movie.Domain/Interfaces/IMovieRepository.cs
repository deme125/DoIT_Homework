using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Domain.Interfaces
{
    public interface IMovieRepository
    {
        ICollection<Movie.Domain.Models.Movie> GetAllMovies();
        bool AddMovie(Movie.Domain.Models.Movie movie);
    }
}
