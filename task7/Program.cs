явля/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/ 

int InputInt(string message)
{
    Console.Write(message + " > ");
    string inputValue = Console.ReadLine()!;
    int result = Convert.ToInt32(inputValue);
    return result;
}

int number  = InputInt("Введите число, чтобы узнать какой это день недели: ");
if(number > 0 && number <= 7)
{
   if(number > 5)
   {
      Console.WriteLine($"{number} - это выходной.");
   }
   else 
   {
      Console.WriteLine($"{number} - это рабочий день.");
   }
}