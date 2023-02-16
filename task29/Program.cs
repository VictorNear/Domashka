// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string msg)
{
   Console.Write(msg + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunc(int firstNumber, int secondNumber)
{
   if (firstNumber == 0)
   {
      return secondNumber + 1;
   }
   if (firstNumber != 0 && secondNumber == 0)
   {
      return AckermannFunc(firstNumber - 1, 1);
   }
   if (firstNumber > 0 && secondNumber > 0)
   {
      return AckermannFunc(firstNumber - 1, AckermannFunc(firstNumber, secondNumber - 1));
   }
   return AckermannFunc(firstNumber, secondNumber);
}

int firstNumber = InputInt("Введите");
int secondNumber = InputInt("Введите");
Console.WriteLine($"Функция Аккермана для чисел {firstNumber}, {secondNumber} -> {AckermannFunc(firstNumber, secondNumber)}");