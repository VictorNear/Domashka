// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string message)
{
   Console.Write(message + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size)
{
   int[] array = new int[size];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = int.Parse(Console.ReadLine());
   }
   return array;
}

int CountPositiveNumber(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if(array[i] > 0)
      {
         count++;
      }
   }
   return count;
}

int size = InputInt("Введите количество элементов массива");
System.Console.WriteLine("Введите элемент массива, после ввода нажмите ENTER:");
int[] array = FillArray(size);
Console.WriteLine($"Положительных чисел в массиве -> {CountPositiveNumber(array)}");