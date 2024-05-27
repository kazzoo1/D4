using System;

class Matrix
{
    private int[,] data;

    public Matrix(int rows, int cols)
    {
        data = new int[rows, cols];
    }

    public void FillRandom(int min, int max)
    {
        Random rnd = new Random();
        for (int i = 0; i < data.GetLength(0); i++)
            for (int j = 0; j < data.GetLength(1); j++)
                data[i, j] = rnd.Next(min, max);
    }

    public static Matrix operator %(Matrix m, int num)
    {
        Matrix result = new Matrix(m.data.GetLength(0), m.data.GetLength(1));
        for (int i = 0; i < m.data.GetLength(0); i++)
        {
            for (int j = 0; j < m.data.GetLength(1); j++)
            {
                result.data[i, j] = m.data[i, j] % num;
            }
        }
        return result;
    }

    public void Print()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write(data[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Matrix matrix = new Matrix(3, 3);
        matrix.FillRandom(0, 100);
        Console.WriteLine("Исходная матрица:");
        matrix.Print();
        Console.Write("Введите число для деления: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Matrix remainderMatrix = matrix % num;
        Console.WriteLine("Матрица остатков:");
        remainderMatrix.Print();
    }
}
