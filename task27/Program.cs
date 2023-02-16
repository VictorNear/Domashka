// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string msg)
{
   Console.Write(msg + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

void PrintEvenNumber(int firstNumber, int secondNumber)
{
   if(firstNumber > secondNumber)
   {
      return;
   }
   if(firstNumber % 2 == 0)
   {
      Console.WriteLine($"{firstNumber}; ");
   PrintEvenNumber(firstNumber + 2, secondNumber);
   }
   else 
   {
      PrintEvenNumber(firstNumber + 1, secondNumber);
   }
}
int firstNumber = InputInt("Введите первое целое число больше ноля");
int secondNumber = InputInt("Введите второе целое число больше ноля");
Console.WriteLine($"Четные натуральные числа в промежутке от {firstNumber} до {secondNumber}:");
PrintEvenNumber(firstNumber, secondNumber);