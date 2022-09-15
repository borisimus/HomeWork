/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

int AkkermanRec(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (n == 0) 
    {
        return AkkermanRec(m - 1, 1);
    }
    return AkkermanRec(m-1, AkkermanRec(m, n-1));
}
int m = 1;
int n = 1;
Console.WriteLine(AkkermanRec(m, n));
