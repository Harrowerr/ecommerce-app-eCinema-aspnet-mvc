using ecommerce_app.Controllers;
using ecommerce_app.Models;
using System.Collections.Generic;

namespace ecommerce_app.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM() 
        {
            Producers = new List<Producer>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();

        }

        public List<Producer> Producers {  get; set; } 
        public List<Cinema> Cinemas {  get; set; } 
        public List<Actor> Actors {  get; set; } 

    }
}
