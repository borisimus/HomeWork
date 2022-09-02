/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]/*  */

Console.Clear();

int[] AddArray(int size = 8)
{
    int[] arr = new int[size];
    Console.WriteLine("Введите число " + size + " раз: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
        /* arr[i] = new Random().Next(10); */
    
    return arr;
}

foreach (var item in AddArray())
{
    Console.Write($" " + item);
}