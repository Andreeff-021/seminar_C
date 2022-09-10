// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Method1(int a)
{
    int i = 0;
    while(a > 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

int number = ReadNumber("Введите число: ");
int n = Method1(number);
Console.WriteLine($"Количество цифр = {n}");