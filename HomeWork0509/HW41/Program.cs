/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается при введении слова "stop"

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.WriteLine($"Введите числа, как только хватит, введите stop: ");

void AddArray(int[] arrayNumbers)
{
    for (int i = 0; ; i++)
    {
      string a = Console.ReadLine();
      if(a == "stop")
      {
        break;
      }
      else
      {
        int b = Convert.ToInt32(a);
        int size = i;
        int[] array = new Array[size];
        a = arr;
        }
    }
}

void PrintAddArray(int[] arrayNumbers)
{
    Console.Write("[");
    for (int i = 0; ; i++)
    {
      Console.Write(arrayNumbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CheckPositiveCount(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < countSize; i++)
    {
        if (arrayNumbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int[] arrayNumbers = new int[size];
int size = arrayNumbers.Length;
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