/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

double[,] GetArray(int rows, int columns)
{
    double[,] arrayResult = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           arrayResult[i, j] = new Random().Next(10);
        }
    }
    return arrayResult;
}

void ShowArray (double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" " + arr[i, j]);
        }
        Console.Write("\n");
    }
}

double[] GetAverageColumns(double[,] array)
{
    double[] arrayResult = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
           sum += array[j, i];
        }
                arrayResult[i] = Math.Round(sum / array.GetLength(0), 2);
    }
    return arrayResult;
}

double[,] arr = GetArray(3, 4);
Console.WriteLine("Задан массив чисел: ");
ShowArray(arr);
Console.Write("\n");
Console.Write("Среднее арифметическое элементов в столбцах равно: ");
foreach (var item in GetAverageColumns(arr))
{
    Console.Write($"{item}; ");
}