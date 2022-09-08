/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается при введении слова "stop"

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int M = new Random().Next(1, 10);
Console.WriteLine($"Введите {M} чисел друг за другом: ");

void AddArray(int[] arrayNumbers)
{
    for (int i = 0; i < M; i++)
    {
      Console.Write($"Введите число {i+1}: ");
      arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintAddArray(int[] arrayNumbers)
{
    Console.Write("[");
    for (int i = 0; i < M; i++)
    {
      Console.Write(arrayNumbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CheckPositiveCount(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if (arrayNumbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] arrayNumbers = new int[M];

AddArray(arrayNumbers);
PrintAddArray(arrayNumbers);
if (CheckPositiveCount(arrayNumbers) == 0)
{
    Console.WriteLine($"Все числа отрицательные!");
}
else
{
    Console.WriteLine($"Количество положительных чисел, введенных пользователем, равно {CheckPositiveCount(arrayNumbers)}");
}