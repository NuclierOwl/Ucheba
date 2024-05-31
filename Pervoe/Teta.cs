using System;

class Program
{
    static void Main()
    {
        double a = 1;
        double b = -3;
        double c = 2;

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");

            double vertexX = -b / (2 * a);
            double vertexY = a * vertexX * vertexX + b * vertexX + c;

            Console.WriteLine($"Вершина параболы: x = {vertexX}, y = {vertexY}");

            if (a > 0)
            {
                Console.WriteLine("Функция возрастает на (-∞, x) и (x, +∞)");
            }
            else
            {
                Console.WriteLine("Функция убывает на (-∞, x) и (x, +∞)");
            }
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Один корень: x = {x}");
        }
        else
        {
            Console.WriteLine("Нет действительных корней");
        }

        if (a == 0)
        {
            double x = -c / b;
            Console.WriteLine($"Прямая пересекает ось Ox в точке x = {x}");
        }
    }
}