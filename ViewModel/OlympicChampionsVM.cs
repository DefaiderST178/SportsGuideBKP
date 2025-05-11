using SportsGuideBKP.Model;
using System.Collections.ObjectModel;

namespace SportsGuideBKP.ViewModel
{
    public class OlympicChampionsVM
    {
        public ObservableCollection<OlympicChampions> OlympicChampions { get; set; } = new();

        public OlympicChampionsVM()
        {
            LoadOlympicChampions();
        }

        private void LoadOlympicChampions()
        {
            var repo = new OlympicChampionsRepo();
            var champions = repo.GetOlympicChampions();
            foreach (var champion in champions)
            {
                OlympicChampions.Add(champion);
            }
        }
    }
}
