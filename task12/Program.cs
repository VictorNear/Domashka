// Задача 6*: Напишите программу, которая выводит первые заданные элемента следующей последовательности:
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5

void FillArray(int[] numbers)
{
   int length = numbers.Length;
   int index = 1;
   int count = 1;
   int position = 0;
   while(position < length)
   {
      //int position = 0;
      while(position < index)
      {
         numbers[index] = count;
         System.Console.WriteLine(numbers[index]);
         position++;
         //index++;
         //if(position > 12)
         {
         //break;
         }
      } 
      count++;
      index = index + count;
      //position++;     
   }
   //count++;   
}
int[] array = new int[12];
FillArray(array);