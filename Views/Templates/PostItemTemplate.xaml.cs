
using bhknjizevniciapp.Models;


namespace bhknjizevniciapp.Views.Templates;


public partial class PostItemTemplate : ContentView
{
    

    public PostItemTemplate()
    {
        InitializeComponent();
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var post = (sender as Button)?.BindingContext as Post;
        if (post != null)
        {
            switch (post.postId)
            {
                case 1:
                   await Navigation.PushAsync(new Abdulah_Sidran());
                    break;
                case 2:
                   await Navigation.PushAsync(new Aleksandar_Hemon());
                        
                    break;
                case 3:
                   await Navigation.PushAsync(new Bisera_Alikadic());
                    break;
                case 4:
                   await Navigation.PushAsync(new Dževad_Karahasan());
                    break;
                case 5:
                  await  Navigation.PushAsync(new Ivo_Andric());
                    break;
                case 6:
                   await Navigation.PushAsync(new Mak_Dizdar());
                    break;
                case 7:
                   await Navigation.PushAsync(new Mesa_Selimovic());
                    break;
                case 8:
                  await  Navigation.PushAsync(new Miljenko_Jergovic());
                    break;
                case 9:
                   await Navigation.PushAsync(new Musa_Cazim_Catic());
                    break;
                case 10:
                   await Navigation.PushAsync(new Zlata_Filipovic());
                    break;
                default:
                    break;
            }
        }
    }
    private bool isFavorit;
    private void HeartIcon_Tapped(object sender, EventArgs e)
    {
        if (isFavorit)
        {
            HeartIcon.Fill = Color.FromHex("#FFFFFF");
            isFavorit = false;
        }
        else
        {
            HeartIcon.Fill = Color.FromHex("#FF0000");
            isFavorit = true;
        }
        var page = GetParentPage(this);
        if (page != null)
        {
            string message = isFavorit ? "Knjizevnik je dodan u favorite!" : "Knjizevnik je uklonjen iz favorita!";
            page.DisplayAlert("Favorite", message, "OK");
        }
    }

    private Page GetParentPage(Element element)
    {
        Element parent = element.Parent;
        while (parent != null)
        {
            if (parent is Page page)
                return page;

            parent = parent.Parent;
        }

        return null;
    }

}
