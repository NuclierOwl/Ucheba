using System;
using System.Collections.Generic;
using System.Linq;

public class Star
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public string Description { get; set; }
    public int ConstellationId { get; set; }
    public string StarSize { get; set; }
}

public class Constellation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Star> Stars { get; set; } = new List<Star>();
}

public class DatabaseManager
{
    public List<Star> Stars { get; private set; } = new List<Star>();
    public List<Constellation> Constellations { get; private set; } = new List<Constellation>();

    public void LoadDataFromDatabase()
    {
        // Здесь должен быть код для загрузки данных из базы данных
        // Это пример, данные должны быть загружены из реальной базы данных
        Stars.Add(new Star { Id = 1, Name = "Сириус", CoordinateX = -1.46, CoordinateY = 8.6, Description = "Самая яркая звезда ночного неба", ConstellationId = 1, StarSize = "large" });
        Constellations.Add(new Constellation { Id = 1, Name = "Большой Пёс", Description = "Созвездие южного полушария неба" });
    }

    public void DisplayStarsInformation()
    {
        foreach (var constellation in Constellations)
        {
            Console.WriteLine($"Созвездие: {constellation.Name}");
            var starsInConstellation = Stars.Where(s => s.ConstellationId == constellation.Id).ToList();
            foreach (var star in starsInConstellation)
            {
                Console.WriteLine($"Звезда: {star.Name} ({star.StarSize})");
            }
        }
    }

    public void DisplayStarDetails(int starId)
    {
        var star = Stars.FirstOrDefault(s => s.Id == starId);
        if (star != null)
        {
            var constellation = Constellations.FirstOrDefault(c => c.Id == star.ConstellationId);
            Console.WriteLine($"Название звезды: {star.Name}");
            Console.WriteLine($"Описание: {star.Description}");
            Console.WriteLine($"Координаты: X: {star.CoordinateX}, Y: {star.CoordinateY}");
            if (constellation != null)
            {
                Console.WriteLine($"Созвездие: {constellation.Name}");
                Console.WriteLine($"Описание созвездия: {constellation.Description}");
            }
        }
        else
        {
            Console.WriteLine("Звезда не найдена.");
        }
    }

    public void DisplayStarDetails(string starName)
    {
        var star = Stars.FirstOrDefault(s => s.Name.Equals(starName, StringComparison.OrdinalIgnoreCase));
        if (star != null)
        {
            DisplayStarDetails(star.Id);
        }
        else
        {
            Console.WriteLine("Звезда не найдена.");
        }
    }
}

public class ClientApplication
{
    private DatabaseManager dbManager = new DatabaseManager();

    public void RunApplication()
    {
        dbManager.LoadDataFromDatabase();
        dbManager.DisplayStarsInformation();

        Console.WriteLine("Введите ID или название звезды для получения подробной информации:");
        var input = Console.ReadLine();
        if (int.TryParse(input, out int starId))
        {
            dbManager.DisplayStarDetails(starId);
        }
        else
        {
            dbManager.DisplayStarDetails(input);
        }
    }
}

public class Program
{
    public static void Main()
    {
        ClientApplication app = new ClientApplication();
        app.RunApplication();
    }
}
