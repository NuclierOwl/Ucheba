using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y1 = 5 * Math.Pow(x, 2) + 14 * x - 3;
        double x1 = (-14-Math.Sqrt(((14*14)-4*5*(-3)),2))/2*5;
        double x2 = (-14+Math.Sqrt(((14*14)-4*5*(-3)),2))/2*5;

         Console.WriteLine($"Результат для 5x^2+14x-3: {y1}");
         Console.WriteLine($"x1 для 5x^2+14x-3: {x1}");
         Console.WriteLine($"x2 для 5x^2+14x-3: {x2}");

        double y2 = 4 * Math.Pow(x, 3) + Math.Pow(x, 2) - 3 * x - 2;
         x1 = (-1-Math.Sqrt(((1*1)-4*5*(-2)),2))/2*4;
         x2 = (-1+Math.Sqrt(((1*1)-4*5*(-2)),2))/2*4;

         Console.WriteLine($"Результат для 4x^3+x^2-3x-2: {y2}");
         Console.WriteLine($"x1 для 4x^3+x^2-3x-2: {x1}");
         Console.WriteLine($"x2 для 4x^3+x^2-3x-2: {x2}");

        double y3 = 5 * Math.Pow(Math.Sin(x), 2) + 6 * Math.Cos(x) - 6;
         x1 = (-6-Math.Sqrt(((6*6)-4*5*(-6)),2))/2*5;
         x2 = (-6+Math.Sqrt(((6*6)-4*5*(-6)),2))/2*5;

        
        Console.WriteLine($"Результат для 5sin^2x+6cosx-6: {y3}");
         Console.WriteLine($"x1 для 5sin^2x+6cosx-6: {x1}");
         Console.WriteLine($"x2 для 5sin^2x+6cosx-6: {x2}");
    }
}