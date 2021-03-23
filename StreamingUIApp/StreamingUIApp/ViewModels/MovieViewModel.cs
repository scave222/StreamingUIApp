using StreamingUIApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StreamingUIApp.ViewModels
{
    public class MovieViewModel
    {
        public ObservableCollection<Movie> movie { get; set; }

        public MovieViewModel()
        {
            movie = new ObservableCollection<Movie>
            {
                new Movie { MoviePicture = "ll"},
                new Movie { MoviePicture = "Movie0"},
                new Movie { MoviePicture = "Movie1"},
                new Movie { MoviePicture = "Movie2"},
                new Movie { MoviePicture = "Movie3"},
                new Movie { MoviePicture = "Movie4"},
                new Movie { MoviePicture = "Movie5"}
            };
        }
    }
}
