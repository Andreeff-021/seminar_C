Console.WriteLine("Ведите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());

int x = n1 % n2;

if (n1 % n2 == 0)
{
    Console.WriteLine("Кратны");
}
else
{
   Console.WriteLine($"Остаток {x}"); 
}