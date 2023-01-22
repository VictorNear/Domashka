/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Не используйте строки.
14212 -> нет
12821 -> да
23432 -> да*/ 

int InputInt(string message)
{
    Console.Write(message + " > ");
    string inputValue = Console.ReadLine()!;
    int result = Convert.ToInt32(inputValue);
    return result;
}

int number  = InputInt("Введите число, чтобы узнать является ли оно палиндромом: ");
int number2 = 0;
int check = number;

while (number != 0)
{
   int intermediateNumber = number % 10;
   number = number / 10;
   number2 = number2 * 10 + intermediateNumber;
}
if(number2 == check)
{
   Console.WriteLine($"{check} - палиндром");
}
else 
{
   Console.WriteLine($"{check} - не палиндром");
}





