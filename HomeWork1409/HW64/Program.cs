/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8"" */

Console.Clear();
string GetNatural(int M, int N)
{
if (N == M) 
{
    return Convert.ToString(M);
}
return M + ", " + GetNatural(M + 1, N);
}

int M = 1;
int N = 5;
Console.WriteLine($"Натуральные числа от {M} до {N}: {GetNatural(M, N)}");