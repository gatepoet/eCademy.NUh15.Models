using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
    }
}