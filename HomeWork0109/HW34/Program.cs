/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

void AddArray(int[] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
      arrayNumbers[i] = new Random().Next(100, 1000);
    }
}
void PrintAddArray(int[] arrayNumbers)
{
    Console.Write("[");
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
      Console.Write(arrayNumbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[size];
AddArray(arrayNumbers);
Console.Write("Задан массив: ");
PrintAddArray(arrayNumbers);

int count = 0;
for (int n = 0; n < arrayNumbers.Length; n++)
{
  if(arrayNumbers[n] % 2 == 0)
  {
    count++;
  }
}
Console.WriteLine($"В массиве {arrayNumbers.Length} числа(-ел), из которых {count} четные");