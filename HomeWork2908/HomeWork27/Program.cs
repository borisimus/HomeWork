/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = Convert.ToString(number).Length;
int result = 0;
int advance = 0;

int SumElements (int number)
{
    for (int i = 0; i < count; i++)
    {
        advance = number - number % 10;
        result += number - advance;
        number /= 10;
    }
    return result;
}

int SumNumber = SumElements(number);
Console.Write($"Сумма элементов в числе {number} равна: " + SumNumber);