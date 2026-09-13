using Microsoft.EntityFrameworkCore;
using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Infrastructure.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie.Domain.Models.Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<StudioDetails> StudioDetails { get; set; }
    }
}
