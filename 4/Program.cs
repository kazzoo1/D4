using System;

class Program
{
    // Перегрузка метода Sum
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    // Перегрузка метода Min
    static int Min(int a, int b)
    {
        return (a < b) ? a : b;
    }

    static int Min(int a, int b, int c)
    {
        return Min(Min(a, b), c);
    }

    // Перегрузка метода Max
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int Max(int a, int b, int c)
    {
        return Max(Max(a, b), c);
    }

    static void Main(string[] args)
    {
        Console.Write("Введите a1: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите a2: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите c2: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        int sumResult = Sum(a1, b1) + Sum(a2, b2, c2);
        int minResult = Min(a1, b1) * Min(a2, b2, c2);
        int maxResult = Max(a1, b1) - Max(a2, b2, c2);

        Console.WriteLine($"Результат Sum: {sumResult}");
        Console.WriteLine($"Результат Min: {minResult}");
        Console.WriteLine($"Результат Max: {maxResult}");
    }
}
