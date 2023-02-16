// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputInt(string msg)
{
   Console.Write(msg + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
void SummNumbers(int firstNumber, int secondNumber, int sum)
{
   sum = sum + firstNumber;
   if (firstNumber == secondNumber)
   {
      Console.WriteLine(sum);
      return;
   }
   SummNumbers(firstNumber + 1, secondNumber, sum);
}

int firstNumber = InputInt("Введите число");
int secondNumber = InputInt("Введите число");
Console.Write($"Сумма чисел от {firstNumber} до {secondNumber} -> ");
SummNumbers(firstNumber, secondNumber, sum);

