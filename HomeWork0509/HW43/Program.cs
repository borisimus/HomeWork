/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 

k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1

x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1

значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

double[,] coefficients = new double[2, 2];
double[] getPoint = new double[2];

void AddCoefficients()
{    
    for (int i = 0; i < coefficients.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coefficients.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coefficients[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
double[] Decision(double[,] coefficients)
{
  getPoint[0] = (coefficients[1,1] - coefficients[0,1]) / (coefficients[0,0] - coefficients[1,0]);
  getPoint[1] = getPoint[0] * coefficients[0,0] + coefficients[0,1];
  return getPoint;
}

void OutputResponse(double[,] coefficients)
{
  if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] == coefficients[1,1]) 
  {
    Console.Write("Прямые совпадают");
  }
  else if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] != coefficients[1,1]) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    Decision(coefficients);
    Console.Write($"Точка пересечения прямых: ({getPoint[0]}, {getPoint[1]})");
  }
}

AddCoefficients();
OutputResponse(coefficients);