// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputInt(string message)
{
   Console.Write(message + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

int number = InputInt("Введите число");
int count = 1;

while(count <= number)
{
double result = Math.Pow(count, 3);
Console.WriteLine(result);
count ++;
}
