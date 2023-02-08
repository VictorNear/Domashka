// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateBaseArray(int lines, int columns)
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

void PrintArray(int[,] array, string msg)
{
   Console.WriteLine(msg);
   for (int i = 0; i < array.GetLength(0); i++)
   {
      Console.WriteLine();
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + "  ");
      }
   }
   Console.WriteLine();
}

int[,] ChangeArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(1) - 1; k++)
         {
            if (array[i, k] < array[i, k + 1])
            {
               int temp = array[i, k + 1];
               array[i, k + 1] = array[i, k];
               array[i, k] = temp;
            }
         }
      }
   }
   return array;
}

int[,] baseArray = CreateBaseArray(3, 5);
PrintArray(baseArray, "Базовый массив:");
Console.WriteLine();
int[,] changeArray = ChangeArray(baseArray);
PrintArray(changeArray, "Отсортированный массив:");
