namespace bhknjizevniciapp;


using CommunityToolkit.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("DancingScript-SemiBold.ttf", "DancingScriptSemiBold");
                fonts.AddFont("LobsterTwo-Italic.ttf", "LobsterTwoItalic");
                fonts.AddFont("CormorantGaramond-Light.ttf", "CormorantGaramord");
            });

  
        return builder.Build();
    }
}
