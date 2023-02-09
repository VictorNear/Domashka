// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int lines, int columns)
{
   Random rnd = new Random();
   int[,] array = new int[lines, columns];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = rnd.Next(10);
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
         Console.Write(array[i, j] + "  ");
      }
      Console.WriteLine();
   }
}

int NumberMinSumString(int[,] array)
{
   int minSumStr = 0;
   int sumStr = 0;
   int indexMinSumString = 0;
   for (int k = 0; k < array.GetLength(1); k++)
   {
      minSumStr += array[0, k];
   }
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      sumStr += array[i, j];
      if (sumStr < minSumStr)
      {
         minSumStr = sumStr;
         indexMinSumString = i;
      }
      sumStr = 0;
   }
   return indexMinSumString;
}

int[,] myArray = CreateArray(4, 3);
PrintArray(myArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: " + (NumberMinSumString(myArray) + 1));


