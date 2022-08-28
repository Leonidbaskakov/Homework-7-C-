// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите число строк ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] FillArray(int row, int col, double min, double max)
{
    double[,] array = new double[row, col];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()* 10;
        }
    }
    return array;
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{Math.Round(array[i, j],2),5},");
            else Console.Write($"{Math.Round(array[i, j],2),5}");
        }
        Console.WriteLine("]");
    }
}

double[,] result = FillArray(row, col, 0, 10);
PrintArr(result);
