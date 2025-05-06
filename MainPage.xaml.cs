
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
            //await Navigation.PushAsync(new SecondPage());
        }
        private async void OnWinterFrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WinterGamesView());
        }
    }
}