using SportsGuideBKP.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportsGuideBKP.ViewModel
{
    public class OlympicWinnersVM : INotifyPropertyChanged
    {
        private ObservableCollection<OlympicWinners> _OlympicWinners;
        public ObservableCollection<OlympicWinners> OlympicWinners
        {
            get { return _OlympicWinners; }
            set { _OlympicWinners = value; OnPropertyChanged(); }
        }

        private OlympicWinners _selectedOlympicWinners;
        public OlympicWinners SelectedOlympicWinners
        {
            get { return _selectedOlympicWinners; }
            set { _selectedOlympicWinners = value; OnPropertyChanged(); }
        }

        public OlympicWinnersVM()
        {
            OlympicWinnersRepo olympicWinnersRepo = new OlympicWinnersRepo();
            List<OlympicWinners> allOlympicWinners = olympicWinnersRepo.GetAllOlympicWinners();
            OlympicWinners = new ObservableCollection<OlympicWinners>(allOlympicWinners);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
