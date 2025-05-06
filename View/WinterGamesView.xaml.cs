using SportsGuideBKP.Model;
using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP.View;

public partial class WinterGamesView : ContentPage
{
	public WinterGamesView()
	{
		InitializeComponent();
        WinterGamesVM winterGamesVM = new WinterGamesVM();
        BindingContext = winterGamesVM;
    }

    private void WinterGamesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedWinterGames = e.SelectedItem as OlympicGames;

        Navigation.PushAsync(new SelectedGame(selectedWinterGames));

        WinterGamesList.SelectedItem = null;
    }
}