using SportsGuideBKP.View;

namespace SportsGuideBKP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
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
    }
}