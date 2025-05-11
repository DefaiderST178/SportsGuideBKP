namespace SportsGuideBKP.Model
{
    public class OlympicChampionsRepo
    {
        List<OlympicChampions> AllOlympicChampions = new List<OlympicChampions>()
        {
            new OlympicChampions
            {
                ID = 1,
                Name = "Марк Спитц",
                Image = "mark_spitz.jpg",
                Biography = "Марк Эндрю Спитц (родился 10 февраля 1950 года в Модесто, Калифорния, США) — американский пловец еврейского происхождения, девятикратный чемпион Олимпийских игр по плаванию.\r\nВ 1967 установил свой первый мировой рекорд (400 м вольным стилем) и выиграл 5 золотых медалей на Панамериканских играх.",
                SportDiscipline = "Плавание",
                TotalMedals = 11,
                Country = "США"
            },
            new OlympicChampions
            {
                ID = 2,
                Name = "Майкл Фелпс",
                Image = "michael_phelps.jpg",
                Biography = "Родился 30 июня 1985 года в Балтиморе (штат Мэриленд, США). Был младшим из трёх детей.\r\nНачал заниматься плаванием в возрасте семи лет, отчасти под влиянием своей сестры.\r\nВ 2001 году установил мировой рекорд на дистанции 200 м баттерфляем, став самым молодым пловцом, достигшим такого результата.",
                SportDiscipline = "Плавание",
                TotalMedals = 28,
                Country = "США"
            },
            new OlympicChampions
            {
                ID = 3,
                Name = "Кэти Ледеки",
                Image = "katie_ledecky.jpg",
                Biography = "Кэти Ледеки — американская пловчиха, специализирующаяся на плавании вольным стилем на средних и длинных дистанциях (200, 400, 800 и 1500 метров).\r\nДебютировала на Олимпиаде-2012 в Лондоне в возрасте 15 лет, завоевала золото на дистанции 800 м вольным стилем.",
                SportDiscipline = "Плавание",
                TotalMedals = 14,
                Country = "США"
            },
        };
        public List<OlympicChampions> GetOlympicChampions()
        {
            return AllOlympicChampions;
        }
    }
}
