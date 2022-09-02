/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
Console.Clear();
int result = 1;
int GetPow (int numberA, int numberB)
{
    if (numberB == 0)
    {
        return 1;
    }
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int PowAB = GetPow(numberA, numberB);
Console.Write($"Возведение числа {numberA} в степень числа {numberB} равно: " + PowAB);