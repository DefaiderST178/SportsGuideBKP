using SportsGuideBKP.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportsGuideBKP.ViewModel
{
    public class WinterGamesVM : INotifyPropertyChanged
    {
        private ObservableCollection<OlympicGames> _WinterOlympicGames;
        public ObservableCollection<OlympicGames> WinterOlympicGames
        {
            get { return _WinterOlympicGames; }
            set { _WinterOlympicGames = value; OnPropertyChanged(); }
        }

        private OlympicGames _selectedWinterOlympicGames;
        public OlympicGames Selected_selectedWinterOlympicGames
        {
            get { return _selectedWinterOlympicGames; }
            set { _selectedWinterOlympicGames = value; OnPropertyChanged(); }
        }

        public WinterGamesVM()
        {
            SummerGamesRepo winterGamesRepo = new SummerGamesRepo();
            List<OlympicGames> allWinterOlympicGames = winterGamesRepo.GetAllWinterGames();
            WinterOlympicGames = new ObservableCollection<OlympicGames>(allWinterOlympicGames);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
