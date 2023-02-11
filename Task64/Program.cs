//Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNnumbersNto1(int num)
{
    if (num != 0)
    {
        Console.Write(num);
        PrintNnumbersNto1(num - 1);

    }
}

Console.Write("Введите целое число -> ");
string temp = Console.ReadLine();
int number = 0;

if (int.TryParse(temp, out number))
{
    int.TryParse(temp, out number);
    Console.Write($" N ={number} -> ");
    PrintNnumbersNto1(number);
}
else
{
    Console.WriteLine("Вы ввели не целе число!");
}

