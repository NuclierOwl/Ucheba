using System;

class Program
{
    static void Main()
    {
        double a, b, c, d, start, end, step;

        Console.WriteLine("Введите коэффициенты a, b, c, d:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        d = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите начальное значение диапазона:");
        start = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите конечное значение диапазона:");
        end = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите шаг:");
        step = Convert.ToDouble(Console.ReadLine());

        for (double x = start; x <= end; x += step)
        {
            double linear = a * x;
            double quadratic = a * x * x + b * x + c;
            double cubic = a * x * x * x + b * x * x + c * x + d;

            Console.WriteLine($"Для x = {x}: Линейная функция = {linear}, Квадратичная функция = {quadratic}, Кубическая функция = {cubic}");
        }
    }
}
