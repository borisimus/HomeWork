/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */
Console.Clear();

int[,] array = new int[3, 4];
 GetArray(array);
 Console.WriteLine("Задан массив:");
 PrintArray(array);
 Console.WriteLine("Отсортированный массив:");
 SortArray(array);
 PrintArray(array);

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
       /*  return arr; */
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

 void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array [i, k + 1])
                {
                    int temp = array [i, k + 1];
                    array [i, k + 1] = array [i, k];
                    array [i, k] = temp;
                }
            }
        }
    }
}