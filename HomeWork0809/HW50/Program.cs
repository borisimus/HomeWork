/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. Если есть - выводим элемент по этим индексам. */

Console.Clear();
int rows = GetLength[0];
int columns = GetLength[1];

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

bool Contains(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
bool PositionElement(int[,] array)
{
    double [,] result = new arr[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i < rows && j < columns)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
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
Contains(arr(i, j), 45);