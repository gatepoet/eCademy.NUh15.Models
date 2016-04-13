using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models1.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieContext : DbContext
    {
        public MovieContext()
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}