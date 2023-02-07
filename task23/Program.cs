// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputInt(string message)
{
   Console.Write(message + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int lines, int columns)
{
   Random rnd = new Random();
   int[,] array = new int[lines, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = rnd.Next(1, 10);
      }
   }
   return array;
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + "   ");
      }
      Console.WriteLine();
   }
}

double SumColumns(int[,] array, int columns)
{
   double sum = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      sum += array[i, columns];
   }
   return Math.Round(sum / array.GetLength(0), 1);
}

int readLines = InputInt("Введите количество строк в массиве");
int readColumns = InputInt("Введите количество столбцов в массиве");
int[,] resultArray = FillArray(readLines, readColumns);
PrintArray(resultArray);
Console.WriteLine("Среднее арифметическое столбцов:");

void PrintSumColumns()
{
   for (int i = 0; i < readColumns; i++)
   {
      double resultSum = SumColumns(resultArray, i);
      Console.Write(resultSum + "  ");
   }
}
PrintSumColumns();