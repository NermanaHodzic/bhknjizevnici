using bhknjizevniciapp.Services;

using bhknjizevniciapp.Models;
using System.Collections.ObjectModel;

namespace bhknjizevniciapp.ViewModels
{
    public class HomeViewModel : ContentView
    {
        ObservableCollection<Author> _authors;
        ObservableCollection<Post> _posts;
        private string _selectedGenre;

        public HomeViewModel()
        {
            LoadData();
            SelectedGenre = null;
        }

        public ObservableCollection<Author> Authors
        {
            get { return _authors; }
            set
            {
                _authors = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set
            {
                _posts = value;
                OnPropertyChanged();
            }
        }

        void LoadData()
        {
            Authors = new ObservableCollection<Author>(AuthorService.Instance.GetAuthors());
            Posts = new ObservableCollection<Post>(PostService.Instance.GetPosts());
        }
        public string SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                _selectedGenre = value;
                OnPropertyChanged();

                FilterPostsByGenre();
            }
        }
        private void FilterPostsByGenre()
        {
            if (string.IsNullOrEmpty(SelectedGenre))
            {
                // Ako nije odabran žanr, prikaži sve postove
                Posts = new ObservableCollection<Post>(PostService.Instance.GetPosts());
            }
            else
            {
                // Filtriranje postova na osnovu odabranog žanra
                Posts = new ObservableCollection<Post>(PostService.Instance.GetPosts().Where(p => p.Genres.Contains(SelectedGenre)));
            }
        }
    }
}