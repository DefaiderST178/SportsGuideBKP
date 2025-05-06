using SportsGuideBKP.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportsGuideBKP.ViewModel
{
    public class SummerGamesVM : INotifyPropertyChanged
    {
        private ObservableCollection<OlympicGames> _SummerOlympicGames;
        public ObservableCollection<OlympicGames> SummerOlympicGames
        {
            get { return _SummerOlympicGames; }
            set { _SummerOlympicGames = value; OnPropertyChanged(); }
        }

        private OlympicGames _selectedSummerOlympicGames;
        public OlympicGames Selected_selectedSummerOlympicGames
        {
            get { return _selectedSummerOlympicGames; }
            set { _selectedSummerOlympicGames = value; OnPropertyChanged(); }
        }

        public SummerGamesVM()
        {
            SummerGamesRepo summerGamesRepo = new SummerGamesRepo();
            List<OlympicGames> allSummerOlympicGames = summerGamesRepo.GetAllWinterGames();
            SummerOlympicGames = new ObservableCollection<OlympicGames>(allSummerOlympicGames);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
