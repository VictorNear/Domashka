// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
//в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double InputInt(string message)
{
   Console.Write(message + " ");
   string inputValue = Console.ReadLine()!;
   double result = Convert.ToInt32(inputValue);
   return result;
}

double GetLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) +Math.Pow(z1-z2, 2));
}  
 
Console.WriteLine("Введите координаты первой точки: ");
double x1 = InputInt("x1 = ");
double y1 = InputInt("y1 = ");
double z1 = InputInt("z1 = ");
Console.WriteLine("Введите координаты второй точки: ");
double x2 = InputInt("x2 = ");
double y2 = InputInt("y2 = ");
double z2 = InputInt("z2 = ");

double length = GetLength(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между двумя точками = {length}");