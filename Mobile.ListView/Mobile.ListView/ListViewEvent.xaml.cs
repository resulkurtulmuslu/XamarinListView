using Mobile.ListView.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewEvent : ContentPage
    {
        List<MovieGrup> movies = new List<MovieGrup>();

        public ListViewEvent()
        {
            InitializeComponent();

            movies.Add(new MovieGrup("Komedi", "KMD")
            {
                new Movie{Id = 1, Name = "Joker" , Directory = "Todd Phillips", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 1, Name = "Joker" , Directory = "Todd Phillips", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 1, Name = "Joker" , Directory = "Todd Phillips", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 1, Name = "Joker" , Directory = "Todd Phillips", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 1, Name = "Joker" , Directory = "Todd Phillips", ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"}
            });

            movies.Add(new MovieGrup("Macera", "MCR")
            {
                new Movie{Id = 5, Name = "Avengers: Endgame" , Directory = "Anthony Russo", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 5, Name = "Avengers: Endgame" , Directory = "Anthony Russo", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 5, Name = "Avengers: Endgame" , Directory = "Anthony Russo", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 5, Name = "Avengers: Endgame" , Directory = "Anthony Russo", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie{Id = 5, Name = "Avengers: Endgame" , Directory = "Anthony Russo", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"}
            });

            lstView.ItemsSource = movies;
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selected", "Selected", "OK");
        }

        private void lstView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Tapped", "Tapped", "OK");
        }
    }
}