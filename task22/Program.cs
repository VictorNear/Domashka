// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
         array[i, j] = rnd.Next(0, 100);
      }
   }
   return array;    
}

void PrintArray(int[,] array)
{
   Console.WriteLine();
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + "  ");
      }
      Console.WriteLine();
   }
}

void SearchArrayElement(int[,]array, int inputLines, int inputColumns)
{
   if (inputLines <= array.GetLength(0) && inputColumns <= array.GetLength(1))
   {
      Console.WriteLine($"По такому адресу находится элемент -> {array[inputLines, inputColumns]}");
   }
   else 
   {
      Console.WriteLine("Такого элемента нет.");
   }
}

int inputLines = InputInt("Введите позицию строки элемента");
int inputColumns = InputInt("Введите позицию столбца элемента");
int[,] resultArray = FillArray(5, 6);
PrintArray(resultArray);
SearchArrayElement(resultArray, inputLines, inputColumns);

