// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
   int[] array = new int[size];
   Random rnd = new Random();
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = rnd.Next(-99, 100);
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

int SumOfNumbersOnOddIndexes(int[] array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i = i + 2)
   {
      sum = sum + array[i];
   }
   return sum;
}

int[] array = CreateArray(size);
PrintArray(array);
int sumNumbers = SumOfNumbersOnOddIndexes(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях -> {sumNumbers}");
