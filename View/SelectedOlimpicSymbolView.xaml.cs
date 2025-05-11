namespace SportsGuideBKP.View;

public partial class SelectedOlimpicSymbolView : ContentPage
{
	public SelectedOlimpicSymbolView(Model.OlympicSymbols selectedSymbol)
	{
		InitializeComponent();
        BindingContext = selectedSymbol;
    }

    private async void BackNavBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}