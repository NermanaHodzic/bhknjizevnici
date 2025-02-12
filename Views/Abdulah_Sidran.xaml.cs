

namespace bhknjizevniciapp.Views;

public partial class Abdulah_Sidran : ContentPage
{
    public Abdulah_Sidran(Models.Author foundAuthor)
    {
        InitializeComponent();
    }

    public Abdulah_Sidran()
    {
        InitializeComponent();
    }

    private void OnPlayButtonTapped(object sender, EventArgs e)
    {
        mediaElement.Play();
        mediaElement.IsVisible = true;

    }
    private void OnMediaEnded(object sender, EventArgs e)
    {
        playBorder.IsVisible = true;
        mediaElement.IsVisible = false;

    }


}