// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

bool IsNumberInArray(int[] arr, int findNumber)
{
    bool isNumberInArray = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            isNumberInArray = true;
        }
    }
    return isNumberInArray;
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
int find = ReadNumber("Задайти число, которое хотите найти: ");
bool res = IsNumberInArray(array, find);
if (res == true) Console.WriteLine("Число в массиве есть");
else Console.WriteLine("Числа в массиве нет");