using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } // we give it couple of properties
        

    }

    // let's say we want to create page where we randomly pick a movie
    // assuming URL page is /movies/random
}