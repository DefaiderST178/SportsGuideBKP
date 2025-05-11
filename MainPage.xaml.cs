using SportsGuideBKP.Model;
using SportsGuideBKP.View;
using SportsGuideBKP.ViewModel;

namespace SportsGuideBKP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            OlympicChampionsVM olympicChampionsVM = new OlympicChampionsVM();
            BindingContext = olympicChampionsVM;
        }
        // выбор летнего спорта
        private async void OnSummerFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SummerGamesView());
        }
        // выбор зимнего спорта
        private async void OnWinterFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WinterGamesView());
        }
        // выбор победителя
        private async void OnWinnersFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicWinnersView());
        }
        // выбор символа
        private async void OnSymbolsFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicSymbolsView());
        }
        // выбор чемпиона
        private async void Champion_Tapped(object sender, TappedEventArgs e)
        {
            if (e.Parameter is OlympicChampions selectedChampion)
            {
                await Navigation.PushAsync(new SelectedOlympicChampionsView(selectedChampion));
            }
        }
    }
}