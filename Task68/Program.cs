//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int AckermannFunction(int numN, int numM)
{
    if (numN == 0)
    {
        return numM + 1;
    }
    else if (numM == 0)
    {
        return AckermannFunction(numN - 1, 1);
    }
    else
        return AckermannFunction(numN - 1, AckermannFunction(numN, numM - 1));
}
Console.Write("введите первое целое число ->");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе целое число ->");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberN > 0 && numberM > 0)
{
    int result = AckermannFunction(numberN, numberM);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите целое положительное число");
}


