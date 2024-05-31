using System;
using System.Collections.Generic;

// Класс для представления звезды
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

// Класс для представления созвездия
public class Constellation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

// Класс для управления звездами и созвездиями
public class DatabaseManager
{
    private List<Star> stars = new List<Star>();
    private List<Constellation> constellations = new List<Constellation>();

    // Метод для загрузки данных из базы данных в списки
    public void LoadDataFromDatabase()
    {
        // Загрузка данных из базы данных
    }

    // Метод для отображения информации о звездах
    public void DisplayStarsInformation()
    {
        // Отображение информации о звездах
    }

    // Метод для отображения подробной информации о звезде
    public void DisplayStarDetails(int starId)
    {
        // Отображение подробной информации о звезде
    }

    // Метод для отображения подробной информации о звезде
    public void DisplayStarDetails(string starName)
    {
        // Отображение подробной информации о звезде
    }
}

// Класс для управления клиентским приложением
public class ClientApplication
{
    private DatabaseManager dbManager = new DatabaseManager();

    // Метод для запуска клиентского приложения
    public void RunApplication()
    {
        dbManager.LoadDataFromDatabase();
        dbManager.DisplayStarsInformation();

        // Запуск основного цикла приложения
    }
}

// Основной класс программы
public class Program
{
    public static void Main()
    {
        ClientApplication app = new ClientApplication();
        app.RunApplication();
    }
}
