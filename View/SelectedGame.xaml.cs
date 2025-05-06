namespace SportsGuideBKP.View;

public partial class SelectedGame : ContentPage
{
	public SelectedGame(Model.OlympicGames selectedGames)
	{
		InitializeComponent();
        BindingContext = selectedGames;
    }
}