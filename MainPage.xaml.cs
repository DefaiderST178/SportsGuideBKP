using SportsGuideBKP.Model;
using SportsGuideBKP.View;

namespace SportsGuideBKP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // нажатия на панели
        private async void OnSummerFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SummerGamesView());
        }
        private async void OnWinterFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WinterGamesView());
        }

        private async void OnWinnersFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicWinnersView());
        }

        private async void OnSymbolsFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicSymbolsView());
        }

        // Нажатия на кнопки
        private async void SummerNavBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SummerGamesView());
        }

        private async void WinterNavBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WinterGamesView());
        }

        private async void WinnerNavBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicWinnersView());
        }

        private async void SimbolsNavBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlympicSymbolsView());
        }
    }
}