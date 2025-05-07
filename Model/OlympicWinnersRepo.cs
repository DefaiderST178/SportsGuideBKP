namespace SportsGuideBKP.Model
{
    public class OlympicWinnersRepo
    {
        List<OlympicWinners> AllOlympicWinners = new List<OlympicWinners>()
        {
            new OlympicWinners
            {
                ID = 2024001,
                Country = "Соединённые Штаты Америки",
                NumberGoldMedals = 40,
                NumberSilverMedals = 44,
                NumberBronzeMedals = 41,
                TotalMedals = 125
            },
            new OlympicWinners
            {
                ID = 2024002,
                Country = "Китай",
                NumberGoldMedals = 40,
                NumberSilverMedals = 27,
                NumberBronzeMedals = 24,
                TotalMedals = 91
            },
            new OlympicWinners
            {
                ID = 2024003,
                Country = "Япония",
                NumberGoldMedals = 20,
                NumberSilverMedals = 12,
                NumberBronzeMedals = 13,
                TotalMedals = 45
            },
            new OlympicWinners
            {
                ID = 2024004,
                Country = "Австралия",
                NumberGoldMedals = 18,
                NumberSilverMedals = 19,
                NumberBronzeMedals = 16,
                TotalMedals = 53
            },
            new OlympicWinners
            {
                ID = 2024005,
                Country = "Франция (Принимающая страна)",
                NumberGoldMedals = 16,
                NumberSilverMedals = 26,
                NumberBronzeMedals = 22,
                TotalMedals = 64
            },
            new OlympicWinners
            {
                ID = 2024006,
                Country = "Нидерланды",
                NumberGoldMedals = 15,
                NumberSilverMedals = 7,
                NumberBronzeMedals = 12,
                TotalMedals = 34
            },
            new OlympicWinners
            {
                ID = 2024007,
                Country = "Великобритания",
                NumberGoldMedals = 14,
                NumberSilverMedals = 22,
                NumberBronzeMedals = 29,
                TotalMedals = 65
            },
            new OlympicWinners
            {
                ID = 2024008,
                Country = "Южная Корея",
                NumberGoldMedals = 13,
                NumberSilverMedals = 9,
                NumberBronzeMedals = 10,
                TotalMedals = 32
            },
            new OlympicWinners
            {
                ID = 2024009,
                Country = "Италия",
                NumberGoldMedals = 12,
                NumberSilverMedals = 13,
                NumberBronzeMedals = 8,
                TotalMedals = 33
            },
            new OlympicWinners
            {
                ID = 2024010,
                Country = "Германия",
                NumberGoldMedals = 12,
                NumberSilverMedals = 13,
                NumberBronzeMedals = 8,
                TotalMedals = 33
            },
            new OlympicWinners
            {
                ID = 2024011,
                Country = "Новая Зеландия",
                NumberGoldMedals = 10,
                NumberSilverMedals = 7,
                NumberBronzeMedals = 3,
                TotalMedals = 20
            },
            new OlympicWinners
            {
                ID = 2024012,
                Country = "Канада",
                NumberGoldMedals = 9,
                NumberSilverMedals = 7,
                NumberBronzeMedals = 11,
                TotalMedals = 27
            },
            new OlympicWinners
            {
                ID = 2024013,
                Country = "Узбекистан",
                NumberGoldMedals = 8,
                NumberSilverMedals = 2,
                NumberBronzeMedals = 3,
                TotalMedals = 13
            },
            new OlympicWinners
            {
                ID = 2024014,
                Country = "Венгрия",
                NumberGoldMedals = 6,
                NumberSilverMedals = 7,
                NumberBronzeMedals = 6,
                TotalMedals = 19
            },
            new OlympicWinners
            {
                ID = 2024015,
                Country = "Испания",
                NumberGoldMedals = 5,
                NumberSilverMedals = 4,
                NumberBronzeMedals = 9,
                TotalMedals = 18
            },
            new OlympicWinners
            {
                ID = 2024016,
                Country = "Швеция",
                NumberGoldMedals = 4,
                NumberSilverMedals = 4,
                NumberBronzeMedals = 3,
                TotalMedals = 11
            },
            new OlympicWinners
            {
                ID = 2024017,
                Country = "Кения",
                NumberGoldMedals = 4,
                NumberSilverMedals = 2,
                NumberBronzeMedals = 5,
                TotalMedals = 11
            },
            new OlympicWinners
            {
                ID = 2024018,
                Country = "Норвегия",
                NumberGoldMedals = 4,
                NumberSilverMedals = 1,
                NumberBronzeMedals = 3,
                TotalMedals = 8
            },
            new OlympicWinners
            {
                ID = 2024019,
                Country = "Ирландия",
                NumberGoldMedals = 4,
                NumberSilverMedals = 0,
                NumberBronzeMedals = 3,
                TotalMedals = 7
            },
            new OlympicWinners
            {
                ID = 2024020,
                Country = "Бразилия",
                NumberGoldMedals = 3,
                NumberSilverMedals = 7,
                NumberBronzeMedals = 10,
                TotalMedals = 20
            },
        };

        public List<OlympicWinners> GetAllOlympicWinners()
        {
            return AllOlympicWinners;
        }
    }
}