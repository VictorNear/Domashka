// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputInt(string message)
{
   Console.Write(message + " -> ");
   string? inputValue = Console.ReadLine();
   int result = Convert.ToInt32(inputValue);
   return result;
}

int size = InputInt("Введите длину массива");

int[] CreateArray(int size)
{
   int[]array = new int[size];
   Random rnd = new Random();
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = rnd.Next(100, 1000);
   }
   return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]}  ");     
   }
   System.Console.WriteLine();
}

int SumEvenNumbers(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if(array[i] % 2 == 0)
      {
      sum++;
      }
   }
   return sum;
}

int[] array = CreateArray(size);
PrintArray(array);
int summ = SumEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве -> {summ}");