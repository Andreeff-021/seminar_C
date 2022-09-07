Console.WriteLine("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая координатная плоскость");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая координатная плоскость");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья координатная плоскость");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая координатная плоскость");
}
else
{
    Console.WriteLine("X или Y равен нулю");
}