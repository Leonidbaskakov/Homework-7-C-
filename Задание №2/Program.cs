//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] result = FillArray(3, 4, 0, 10);
PrintArr(result);

double[,] FillArray(int row, int col, double min, double max)
{
    double[,] array = new double[row, col];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 10;
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
            if (j < array.GetLength(1) - 1) Console.Write($"{Math.Round(array[i, j], 2),5},");
            else Console.Write($"{Math.Round(array[i, j], 2),5}");
        }
        Console.WriteLine("]");
    }
}

Console.Write("Введите номер строки ");
int row1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите номер столбца ");
int col1 = Convert.ToInt32(Console.ReadLine());

int row3=row1-1;
int col3=col1-1;

void SearchNum(double[,] array, int row2, int col2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (row2 == i && col2 == j) Console.WriteLine($"Число под заданными координатами {Math.Round(array[i, j], 2)}");
        }
    }
    if (row2 >= array.GetLength(0) || col1 >= array.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет");
}


SearchNum(result, row3, col3);