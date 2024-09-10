namespace PAM_Astronomy.Views;
[QueryProperty(nameof(AstroName), "astroName")]
public partial class AstronomicalBodiesView : ContentPage
{
    public AstronomicalBodiesView()
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
    }

    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;
            UpdateAstroBodyUI(astroName);
        }
    }
}


