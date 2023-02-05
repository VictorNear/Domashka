// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt(string message)
{
   Console.Write(message + " -> ");
   return Convert.ToInt32(Console.ReadLine());
}

void CheckCoordinates(double k1, double k2)
{
   if(k1 == k2)
   {
      Console.WriteLine("Прямые не пересекутся");
   }
}

double CoordinatesX(double b1, double b2, double k1,double k2)
{
   double x = (b2 - b1) / (k1 - k2);
   return x;
}

double CoordinatesY(double b1, double k1, double x)
{
   double y = k1 * x + b1;
   return y;
}

double b1 = InputInt("Введите значение b1");
double k1 = InputInt("Введите значение k1");
double b2 = InputInt("Введите значение b2");
double k2 = InputInt("Введите значение k2");
CheckCoordinates(k1, k2);
double resultx = CoordinatesX(b1, b2, k1, k2);
double resulty = CoordinatesY(b1, k1, resultx);
System.Console.WriteLine();
System.Console.WriteLine($"Прямые пересекутся в точке ({resultx}; {resulty})");