using System;

class Program
{
    static void TrianglePS(double a, out double P, out double S)
    {
        P = 3 * a;
        S = (Math.Sqrt(3) / 4) * a * a;
    }

    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Введите сторону a треугольника {i}: ");
            double a = Convert.ToDouble(Console.ReadLine());
            TrianglePS(a, out double P, out double S);
            Console.WriteLine($"Треугольник {i}: Периметр = {P}, Площадь = {S}");
        }
    }
}
