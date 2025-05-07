using SportsGuideBKP.Model;
using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP.View;

public partial class SummerGamesView : ContentPage
{
	public SummerGamesView()
	{
		InitializeComponent();
        SummerGamesVM summerGamesVM = new SummerGamesVM();
        BindingContext = summerGamesVM;
    }

    private void SummerGamesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedSummerGames = e.SelectedItem as OlympicGames;

        Navigation.PushAsync(new SelectedGame(selectedSummerGames));

        SummerGamesList.SelectedItem = null;
    }
}