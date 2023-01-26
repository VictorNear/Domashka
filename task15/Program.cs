// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Сделать через функции.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputInt(string message)
{
   System.Console.Write(message + " -> ");
   string? inputValue = Console.ReadLine();
   int result = Convert.ToInt32(inputValue);
   return result;
}

int size = InputInt("Введите длину массива");
int minNumber = InputInt("Введите минимальное значеение массива");
int maxNumber = InputInt("Введите максимальное значение массива");

int[] CreatArray(int size)
{
   int[] massiv = new int[size];
   Random rnd = new Random();
   for(int i = 0; i < massiv.Length; i++)
   {
      massiv[i] = rnd.Next(minNumber, maxNumber);
   }
   return massiv;
}

void PrintArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}

int[] array = CreatArray(size);
PrintArray(array);