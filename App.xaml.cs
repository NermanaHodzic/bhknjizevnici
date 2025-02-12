
using bhknjizevniciapp.Views;

namespace bhknjizevniciapp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());
    }
}
