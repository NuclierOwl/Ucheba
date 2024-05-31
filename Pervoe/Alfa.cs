using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Недостаточно аргументов. Введите операнд, операцию и операнд.");
            return;
        }

        double operand1 = Convert.ToDouble(args[0]);
        char operation = Convert.ToChar(args[1]);
        double operand2 = Convert.ToDouble(args[2]);
        double result = 0;

        switch (operation)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("Деление на ноль невозможно.");
                    return;
                }
                break;
            case '%':
                result = operand1 % operand2;
                break;
            default:
                Console.WriteLine("Неверная операция. Используйте только +, -, *, /, %.");
                return;
        }

        Console.WriteLine($"Результат: {operand1} {operation} {operand2} = {result}");
    }
}
