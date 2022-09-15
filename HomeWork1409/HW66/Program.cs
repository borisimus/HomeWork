/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetNatural(int M, int N)
{
    /* int sum = 0; */
    /* {
    for (int i = 1; i <= N; i++)
    {
        sum+=i;
    }
    return sum;
} */
    if (M == 0)
    {
        return (N * (N + 1)) / 2;
    }
   else if (N == 0)
   {
        return (M * (M + 1)) / 2;
   }
    else if (M == N)
    {
        return M;
    }
    else if (M < N)
        {
           return N + GetNatural(M, N - 1);
        }
    return N + GetNatural(M, N + 1);
}

Console.WriteLine(GetNatural(4, 8));