// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] FillArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++) //перебор строк
    {
        for (int j = 0; j < array.GetLength(1); j++) //перебор столбцов
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4},");
            else Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] result = FillArray(3, 4, 0, 10);
PrintArr(result);


// void SearchArif(int[,] array)
// {
//     double sum1 = 0;
//     int N = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int S = 0; S < array.GetLength(1); S++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j == S)
//                 {
//                     sum += array[i, j];
//                 }
//             }
//             sum1 = sum / array.GetLength(0);
//         }
//         N++;
//         Console.WriteLine($"Среднее арифметическое {N} строки {Math.Round(sum1, 2)}");
//     }
// }


void SearchArif(int[,] array)
{
    double sum1 = 0;
    int N = 0;
    for (int S = 0; S < array.GetLength(1); S++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (j == S)
                {
                    sum += array[i, j];
                }
            }
        }
        sum1 = sum / array.GetLength(0);
        N++;
        Console.WriteLine($"Среднее арифметическое {N} столбца {Math.Round(sum1, 2)}");
    }
}

SearchArif(result);