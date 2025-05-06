namespace SportsGuideBKP.Model
{
    public class OlympicGames
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public List<string> DopDescription { get; set; }
        public string TopTier { get; set; }
    }
}
