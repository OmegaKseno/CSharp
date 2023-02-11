//Задача 65: Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"
Console.Write("Задайте значение M -> ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N -> ");
int numberN = Convert.ToInt32(Console.ReadLine());
void PrintNnumbers(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write(numM);
        PrintNnumbers(numM + 1, numN);

    }
    else if (numM > numN)
    {
        Console.Write(numM);
        PrintNnumbers(numM - 1, numN);

    }
    else
    {
        Console.Write(numM);
    }

}

PrintNnumbers(numberM, numberN);