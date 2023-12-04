using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCapp.Models
{
    public class MovieGenerateViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
