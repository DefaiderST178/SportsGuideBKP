using SportsGuideBKP.Model;
using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP.View;

public partial class SummerGamesView : ContentPage
{
	public SummerGamesView()
	{
		InitializeComponent();
        WinterGamesVM winterGamesVM = new WinterGamesVM();
        BindingContext = winterGamesVM;
    }

    private void SummerGamesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedWinterGames = e.SelectedItem as OlympicGames;

        Navigation.PushAsync(new SelectedGame(selectedWinterGames));

        SummerGamesList.SelectedItem = null;
    }
}