using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        ConvertToDouble(input);
        
        input = Console.ReadLine();
        ParseToInt(input);
        
        input = Console.ReadLine();
        TryParseToUInt(input);
        
        input = Console.ReadLine();
        TryParseToBool(input);
    }
    
    static void ConvertToDouble(string input)
    {
        if (double.TryParse(input, out double result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Невозможно преобразовать в число с плавающей запятой.");
        }
    }
    
    static void ParseToInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Невозможно преобразовать в целое число.");
        }
    }
    
    static void TryParseToUInt(string input)
    {
        if (uint.TryParse(input, out uint result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Невозможно преобразовать в положительное целое число.");
        }
    }
    
    static void TryParseToBool(string input)
    {
        if (bool.TryParse(input, out bool result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Невозможно преобразовать в логическое значение.");
        }
    }
}
