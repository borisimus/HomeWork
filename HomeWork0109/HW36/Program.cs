/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

void AddArray(int[] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
      arrayNumbers[i] = new Random().Next(-100, 100);
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
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[size];
AddArray(arrayNumbers);
Console.Write("Задан массив: ");
PrintAddArray(arrayNumbers);

int Sum = 0;
for (int n = 0; n < arrayNumbers.Length; n++)
{
        if(n < arrayNumbers.Length && n % 2 == 1)
        {
            Sum += arrayNumbers[n];
        }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных местах, равна {Sum}");