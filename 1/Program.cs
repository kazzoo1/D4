using System;

class Program
{
    static double Function(double x, double a, double b)
    {
        if (x < a)
        {
            return 0;
        }
        else if (x > a)
        {
            return Math.Pow(x - a, 1 / x + a);
        }
        else
        {
            return 1;
        }
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите начало интервала: ");
        double start = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите конец интервала: ");
        double end = Convert.ToDouble(Console.ReadLine());

        for (double x = start; x <= end; x += h)
        {
            Console.WriteLine($"f({x}) = {Function(x, a, b)}");
        }
    }
}
