using System;

internal class Program
{
    private static void Main(string[] args)
    {
        static void Main()
        {
            Console.WriteLine(
                "int" +
                $"\nminvalue: {int.MinValue}" +
                $"\nmaxvalue: {int.MaxValue}" +
                $"\nsize: {sizeof(int)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "long" +
                $"\nminvalue: {long.MinValue}" +
                $"\nmaxvalue: {long.MaxValue}" +
                $"\nsize: {sizeof(long)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "uint" +
                $"\nminvalue: {uint.MinValue}" +
                $"\nmaxvalue: {uint.MaxValue}" +
                $"\nsize: {sizeof(uint)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "double" +
                $"\nminvalue: {double.MinValue}" +
                $"\nmaxvalue: {double.MaxValue}" +
                $"\nsize: {sizeof(double)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "float" +
                $"\nminvalue: {float.MinValue}" +
                $"\nmaxvalue: {float.MaxValue}" +
                $"\nsize: {sizeof(float)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "decimal" +
                $"\nminvalue: {decimal.MinValue}" +
                $"\nmaxvalue: {decimal.MaxValue}" +
                $"\nsize: {sizeof(decimal)} bytes" +
                $"\ndescription: "
            );
            Console.WriteLine(
                "char" +
                $"\nminvalue: {char.MinValue}" +
                $"\nmaxvalue: {char.MaxValue}" +
                $"\nsize: {sizeof(char)} bytes" +
                $"\ndescription: "
            );
        }
    }
}