// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9

int InputInt(string message)
{
   Console.Write(message + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int lines, int columns)
{
   Random rnd = new Random();
   double[,] array = new double[lines, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
      }
   }
   return array;
}

void PrintArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(Math.Round(array[i, j], 1) + "  ");
      }
      Console.WriteLine();
   } 
}

int lines = InputInt("Введите количество строк массива");
int columns = InputInt("Введите количество столбцов массива");
double[,] resultArray = CreateArray(lines, columns);
Console.WriteLine();
PrintArray(resultArray);
