// Задача 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты XA и YA по очереди");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X2 и Y2 по очереди");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
Console.WriteLine(Math.Round(length, 2));