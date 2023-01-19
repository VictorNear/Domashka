/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int InputInt(string message)
{
   Console.Write(message + " > ");
   string inputValue = Console.ReadLine()!;
   int result = Convert.ToInt32(inputValue);
   return result;
}

bool ValidateNumberRank3(int number)
{
   if (number > 99 && number < 1000)
   {
      return true;
   }
      Console.WriteLine("Число не трехзначное");
      return false;
}

int number = InputInt("Введите трехзначное число:");
if(ValidateNumberRank3(number))
{
   int finitResult = number / 10;
   finitResult = finitResult % 10;
   Console.WriteLine($"Вторая цифра числа {number} равна {finitResult}");
}


