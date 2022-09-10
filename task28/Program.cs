// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Method2(int a)
{
    int prod = 1;
    for (int i = 2; i <= a; i++)
    {
        prod = prod * i;
    }
    return prod;
}

int number = ReadNumber("Введите число: ");
int n = Method2(number);
Console.WriteLine($"Происведение равно {n}");