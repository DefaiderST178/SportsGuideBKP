using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP.View;

public partial class OlympicWinnersView : ContentPage
{
	public OlympicWinnersView()
	{
		InitializeComponent();
        OlympicWinnersVM olympicWinnersVM = new OlympicWinnersVM();
        BindingContext = olympicWinnersVM;
    }
}