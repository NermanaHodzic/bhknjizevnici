
using bhknjizevniciapp.Models;
using bhknjizevniciapp.ViewModels;


namespace bhknjizevniciapp.Views;

public partial class HomeView : ContentPage
{
    public HomeView()
    {
        InitializeComponent();
        

    }
    
    private async void OnSearchTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }
    private void GenrePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedGenre = (string)picker.SelectedItem;
        var viewModel = (HomeViewModel)BindingContext;
        viewModel.SelectedGenre = selectedGenre;

        UpdateGenreFramesVisibility(selectedGenre);
    }

    private void UpdateGenreFramesVisibility(string selectedGenre)
    {
        var genreFrames = new List<string>
    {
        "Autobiografija",
        "Esej",
        "Drama",
        "Novela",
        "Poezija",
        "Pripovijetke",
        "Psihologija",
        "Romani"
    };

        foreach (var genreFrame in genreFrames)
        {
            var frame = (Frame)FindByName(genreFrame);
            if (frame != null)
            {
                frame.IsVisible = !genreFrame.Equals(selectedGenre);
            }
        }
    }

}


