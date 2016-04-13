using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models1.Models
{
    public class CreateOrEditMovieViewModel
    {
        public Movie Movie { get; set; }
        public int GenreId { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }
    }
}