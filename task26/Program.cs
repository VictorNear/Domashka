// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintArray(int[,] array, string msg)
{
   Console.WriteLine();
   Console.WriteLine(msg);
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + "  ");
      }
      Console.WriteLine();
   }
}

void CreateMultiplicationArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
   int[,] array = new int[2, 2];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         int temp = 0;
         for (int k = 0; k < array.GetLength(1); k++)
         {
            temp += firstArray[i, k] * secondArray[k, j];
         }
         resultArray[i, j]  = temp;
      }
   }
}

int[,] firstArray = CreateArray(2, 2);
int[,] secondArray = CreateArray(2, 2);
int[,] resultArray = new int[2, 2];
PrintArray(firstArray, "Первый массив:");
PrintArray(secondArray, "Второй массив:");
CreateMultiplicationArray(firstArray, secondArray, resultArray);
PrintArray(resultArray, "Результат перемножения двух массивов:");

