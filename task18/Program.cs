// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной плоскости: ");
int square = Convert.ToInt32(Console.ReadLine());

if(square < 5 && square > 0)
{
    if (square == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if (square == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (square == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
     if (square == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
}
else 
{
    Console.WriteLine("Введите верную координатную плоскость");
}