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

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is OlympicSymbols selectedSymbol)
        {
            await Navigation.PushAsync(new SelectedOlimpicSymbolView(selectedSymbol));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}