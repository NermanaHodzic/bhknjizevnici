

using bhknjizevniciapp.Models;
using bhknjizevniciapp.Services;

namespace bhknjizevniciapp.Views
{
    public partial class SearchPage : ContentPage
    {
        List<Author> authors;

        public SearchPage()
        {
            InitializeComponent();
            authors = AuthorService.Instance.GetAuthors();
            KnjizevniciListView.ItemsSource = authors;
            SearchBar.SearchButtonPressed += OnSearchButtonClicked;
        }

        void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchKeyword = e.NewTextValue;
            if (string.IsNullOrWhiteSpace(searchKeyword))
            {
                KnjizevniciListView.ItemsSource = authors;
            }
            else
            {
                var filteredAuthors = authors.Where(u => u.Name.ToLower().Contains(searchKeyword.ToLower())).ToList();
                KnjizevniciListView.ItemsSource = filteredAuthors;
            }
        }

        async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            string searchKeyword = SearchBar.Text;
            if (string.IsNullOrWhiteSpace(searchKeyword))
            {
                await DisplayAlert("Greška", "Unesite ime književnika", "U redu");
            }
            else
            {
                var foundAuthor = authors.FirstOrDefault(u => u.Name.ToLower() == searchKeyword.ToLower());
                if (foundAuthor != null)
                {
                    await DisplayAlert("Pronaðen književnik", foundAuthor.Name, "U redu");
                    switch (foundAuthor.Name)
                    {
                        case "Abdulah Sidran":
                            await Navigation.PushAsync(new Abdulah_Sidran(foundAuthor));
                            break;
                        case "Aleksandar Hemon":
                            await Navigation.PushAsync(new Aleksandar_Hemon(foundAuthor));
                            break;
                        case "Bisera Alikadic":
                            await Navigation.PushAsync(new Bisera_Alikadic(foundAuthor));
                            break;
                       
                        case "Dževad Karahasan":
                            await Navigation.PushAsync(new Dževad_Karahasan(foundAuthor));
                            break;
                        case "Ivo Andric":
                            await Navigation.PushAsync(new Ivo_Andric(foundAuthor));
                            break;
                        case "Mak Dizdar":
                            await Navigation.PushAsync(new Mak_Dizdar(foundAuthor));
                            break;
                        case "Mesa Selimovic":
                            await Navigation.PushAsync(new Mesa_Selimovic(foundAuthor));
                            break;
                        case "Miljenko Jergovic":
                            await Navigation.PushAsync(new Miljenko_Jergovic(foundAuthor));
                            break;
                        case "Musa Cazim Catic":
                            await Navigation.PushAsync(new Musa_Cazim_Catic(foundAuthor));
                            break;
                        case "Zlata Filipovic":
                            await Navigation.PushAsync(new Zlata_Filipovic(foundAuthor));
                            break;
                        default:
                            await DisplayAlert("Nedostaje stranica", "Nije pronaðena stranica za odabranog književnika", "U redu");
                            break;
                    } 
                }
                else
                {
                    await DisplayAlert("Nema rezultata", "Nažalost, nismo pronašli tog književnika", "U redu");
                }
            }
        }
    }
}
