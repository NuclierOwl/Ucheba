using System;
using Npgsql;

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
    private List<Star> Stars = new List<Star>();
    private List<Constellation> Constellations = new List<Constellation>();

    private string connectionString = "Host=192.168.1.162;Port=5433;Database=user46;Username=user46;Password=y1f20";

    public void LoadDataFromDatabase()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            // Загрузка данных о созвездиях
            using (var command = new NpgsqlCommand("SELECT * FROM constellations", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Constellations.Add(new Constellation
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2)
                        });
                    }
                }
            }

            // Загрузка данных о звездах
            using (var command = new NpgsqlCommand("SELECT * FROM stars", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Stars.Add(new Star
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CoordinateX = reader.GetDouble(2),
                            CoordinateY = reader.GetDouble(3),
                            Description = reader.GetString(4),
                            ConstellationId = reader.GetInt32(5),
                            StarSize = reader.GetString(6)
                        });
                    }
                }
            }
        }
    }






    public void DisplayStarsInformation()
    {
        // Отображение информации о всех звездах
        foreach (var star in Stars)
        {
            Console.WriteLine($"Звезда: {star.Name}, Размер: {star.StarSize}, Координаты: ({star.CoordinateX}, {star.CoordinateY})");
        }
    }

    public void DisplayStarDetails(int starId)
    {
        // Отображение подробной информации о звезде по ID
        var star = Stars.FirstOrDefault(s => s.Id == starId);
        if (star != null)
        {
            Console.WriteLine($"Звезда: {star.Name}");
            Console.WriteLine($"Описание: {star.Description}");
            Console.WriteLine($"Координаты: X: {star.CoordinateX}, Y: {star.CoordinateY}");
            Console.WriteLine($"Размер: {star.StarSize}");
            Console.WriteLine($"Созвездие: {Constellations.FirstOrDefault(c => c.Id == star.ConstellationId)?.Name}");
        }
        else
        {
            Console.WriteLine("Звезда с таким ID не найдена.");
        }
    }

    public void DisplayStarDetails(string starName)
    {
        // Отображение подробной информации о звезде по названию
        var star = Stars.FirstOrDefault(s => s.Name.Equals(starName, StringComparison.OrdinalIgnoreCase));
        if (star != null)
        {
            DisplayStarDetails(star.Id);
        }
        else
        {
            Console.WriteLine("Звезда с таким названием не найдена.");
        }
    }
}

public class ClientApplication
{
    private DatabaseManager dbManager = new DatabaseManager();

    public void RunApplication()
    {
        // Запуск клиентского приложения
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
        // Точка входа в программу
        ClientApplication app = new ClientApplication();
        app.RunApplication();
    }
}
