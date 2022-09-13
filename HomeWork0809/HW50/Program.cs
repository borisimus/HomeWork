/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. Если есть - выводим элемент по этим индексам. */

Console.Clear();

Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int rows, int columns)
{
    int[,] arrayResult = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           arrayResult[i, j] = new Random().Next(100);
        }
    }
    return arrayResult;
}

/* bool Contains(int[,] array, int rows, int columns)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > rows && j > columns)
            {
                return false;
            }
        }
    }
    return true;
}  */

void ShowArray (int[,] arr)
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


int[,] arr = GetArray(10, 10);
ShowArray(arr);

if (rows < arr.GetLength(0) && columns < arr.GetLength(1)) 
{
    Console.WriteLine(arr[rows, columns]);
}
else 
{
    Console.WriteLine("Такой позиции в массиве не существует");
}