namespace SportsGuideBKP.View;

public partial class SelectedGame : ContentPage
{
	public SelectedGame(Model.OlympicGames selectedGames)
	{
		InitializeComponent();
        BindingContext = selectedGames;
    }

    private async void BackNavBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}