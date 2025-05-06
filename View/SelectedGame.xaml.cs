namespace SportsGuideBKP.View;

public partial class SelectedGame : ContentPage
{
	public SelectedGame(Model.OlympicGames selectedWinterGames)
	{
		InitializeComponent();
        BindingContext = selectedWinterGames;
    }
}