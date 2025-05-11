using SportsGuideBKP.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportsGuideBKP.ViewModel
{
    public class OlimpicSymbolsVM : INotifyPropertyChanged
    {
        private ObservableCollection<OlympicSymbols> _OlympicSymbols;
        public ObservableCollection<OlympicSymbols> OlympicSymbols
        {
            get { return _OlympicSymbols; }
            set { _OlympicSymbols = value; OnPropertyChanged(); }
        }

        private OlympicSymbols _selectedOlimpicSymbols;
        public OlympicSymbols SelectedOlimpicSymbols
        {
            get { return _selectedOlimpicSymbols; }
            set { _selectedOlimpicSymbols = value; OnPropertyChanged(); }
        }

        public OlimpicSymbolsVM()
        {
            OlympicSymbolsRepo olympicSymbolsRepo = new OlympicSymbolsRepo();
            List<OlympicSymbols> allOlympicSymbols = olympicSymbolsRepo.GetAllOlympicSymbols();
            OlympicSymbols = new ObservableCollection<OlympicSymbols>(allOlympicSymbols);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
