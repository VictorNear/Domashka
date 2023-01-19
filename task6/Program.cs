/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/ 

int InputInt(string message)
{
    Console.Write(message + " > ");
    string inputValue = Console.ReadLine()!;
    int result = Convert.ToInt32(inputValue);
    return result;
}
bool ValidateNumberRank3(int number)
{
    if (number > 99)
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет.");
    return false;
}

int number = InputInt("Введите число");
if (ValidateNumberRank3(number))
{
   int count = number;
   while(count >= 1000)
   count = count / 10;

   int resultat = count % 10;
   Console.WriteLine($"Третья цифра числа {number} - {resultat}");
}