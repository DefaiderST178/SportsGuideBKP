using SportsGuideBKP.Model;
using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP.View;

public partial class OlympicSymbolsView : ContentPage
{
	public OlympicSymbolsView()
	{
		InitializeComponent();
        OlimpicSymbolsVM olimpicSymbolsVM = new OlimpicSymbolsVM();
        BindingContext = olimpicSymbolsVM;
    }

    private async void Frame_Tapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is OlympicSymbols selectedSymbol)
        {
            await Navigation.PushAsync(new SelectedOlimpicSymbolView(selectedSymbol));
        }
    }
}