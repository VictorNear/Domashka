// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

int InputInt(string message)
{
   Console.Write(message + " -> ");
   string? inputValue = Console.ReadLine();
   int result = Convert.ToInt32(inputValue);
   return result;
}

int size = InputInt("Введите длину массива");
double[] CreateArray(int size)
{
   double[] array = new double[size];
   Random rnd = new Random();
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = rnd.Next(0, 100) + rnd.NextDouble();
   }
   return array;
}

void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]:f2}  ");
   }
   Console.WriteLine();
}

double MaxNumber(double[] array)
{
   double max = array[0];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] > max)
      {
         max = array[i];
      }
   }
   return max;
}

double MinNumber(double[] array)
{
   double min = array[0];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] < min)
      {
         min = array[i];
      }
   }
   return min;
}

double SecondNumber(double[] array, double max)
{
   double secondMax = 0;
   for (int i = 0; i < array.Length; i++)
   {

      if (array[i] > secondMax && array[i] != max)
      {
         secondMax = array[i];
      }

   }
   return secondMax;
}

double[] array = CreateArray(size);
PrintArray(array);
double temp = MaxNumber(array) - MinNumber(array);
Console.Write($"Разность максимального и минимального элемента массива -> {Math.Round(temp, 2)}");
Console.WriteLine();
double secondMaxPrint = SecondNumber(array, MaxNumber(array));
Console.Write($"Второй максимальный элемент массива -> {Math.Round(secondMaxPrint, 2)}");