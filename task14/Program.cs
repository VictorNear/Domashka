// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string message)
{
   System.Console.Write(message + " -> ");
   string inputValue = Console.ReadLine()!;
   int result = Convert.ToInt32(inputValue);
   return result;
}

int SumNumber(int number)
{
   int sum = 0;
   while (number > 0)
   {
      int count = number % 10;
      number = number / 10;
      sum = sum + count;
   }
   return sum;
}

int number = InputInt("Введите число");
System.Console.WriteLine($"Сумма цифр -> {SumNumber(number)}");
