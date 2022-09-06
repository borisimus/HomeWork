/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

void AddArray(double[] arrayNumbers)
{
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
      Random rand = new Random(DateTime.Now.Millisecond);
      arrayNumbers[i] = rand.NextDouble()*20;
    }
}
void PrintAddArray(double[] arrayNumbers)
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
double[] arrayNumbers = new double[size];
AddArray(arrayNumbers);
Console.Write("Задан массив: ");
PrintAddArray(arrayNumbers);

double Max = arrayNumbers[0];
double Min = arrayNumbers[0];
double diff = 0;
for (int n = 1; n < arrayNumbers.Length; n++)
{
        if(arrayNumbers[n] > Max)
        {
            Max = arrayNumbers[n];
        }
        else if (arrayNumbers[n] < Min)
        {
            Min = arrayNumbers[n];
        }

    diff = Max - Min;
}
Console.WriteLine($"Max = {Max}");
Console.WriteLine($"Min = {Min}");
Console.WriteLine($"Разница между макисмальным и минимальным элементовм массива равна равна " + diff);