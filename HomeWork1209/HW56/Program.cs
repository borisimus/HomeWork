/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array = new int[4, 5];

 GetArray(array);
 Console.WriteLine("Задан массив:");
 PrintArray(array);


int minSumRow = 0;
int sumLine = SumElementsRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumElementsRow(array, i);
    if (sumLine > tempSumRow)
    {
    sumLine = tempSumRow;
    minSumRow = i;
    }
}
Console.WriteLine($"Cтрока {minSumRow+1} имеет наименьшую сумму элементов ({sumLine})");

 void GetArray (int[,] array)
 {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = new Random().Next(10);
        }
    }
 }

 void PrintArray (int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

 int SumElementsRow (int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        {
            sumRow += array[i, j];
        }
    }
    return sumRow;
}
