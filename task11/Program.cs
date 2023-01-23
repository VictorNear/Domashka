// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел из 10 
// элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.

void FillArray(int[] collection)
{
   int index = 0;
   int length = collection.Length;
   while (index < length)
   {
      collection[index] = new Random().Next(1, 10);
      Console.WriteLine(collection[index]);
      index++;
   }
}

int CountArray(int[] col)
{
   int number = 0;
   int position = 0;
   int count = col.Length;
   while(position < count)
   {
      if(col[position] > 5)
      {
         number++;
      }
   position++;
   } 
   return number;
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine ($"Количество чисел > 5 = {CountArray(array)}");




   