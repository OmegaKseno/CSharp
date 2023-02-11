
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30



int SumOfElements(int numM, int numN)
{

    if (numM > numN)
    {
        return numM + SumOfElements(numM - 1, numN);

    }
    else if (numM < numN)
    {
        return numM + SumOfElements(numM + 1, numN);
    }

    return numM;
}
Console.Write("Введите первое число : ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = SumOfElements(numberM, numberN);
Console.WriteLine(result);