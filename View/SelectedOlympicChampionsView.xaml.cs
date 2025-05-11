namespace SportsGuideBKP.View;

public partial class SelectedOlympicChampionsView : ContentPage
{
	public SelectedOlympicChampionsView(Model.OlympicChampions selectedChampion)
	{
		InitializeComponent();
        BindingContext = selectedChampion;
    }

    private async void BackNavBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}