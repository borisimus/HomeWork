/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/
Console.Clear();

double[,] GetArray(int rows, int columns)
{
    double[,] arrayResult = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random rnd = new Random();
            arrayResult[i, j] = rnd.NextDouble() * 10;
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

double[,] arr = GetArray(3, 4);
ShowArray(arr);