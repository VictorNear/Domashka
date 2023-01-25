// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string message)
{
   System.Console.Write(message + " -> ");
   string inputValue = Console.ReadLine()!;
   int result = Convert.ToInt32(inputValue);
   return result;
}

int number = InputInt("Введите число");
int degree = InputInt("Введите степень, в которую надо возвести число");

int Exponentiation(int degree)
{
   int resultat = 1;   
   for(int i = 0; i < degree; i++)
   {
      resultat = resultat * number;
   }
   return resultat;
}

int resultExponent = Exponentiation(degree);
System.Console.WriteLine($"{number} в степени {degree} = {resultExponent}");
