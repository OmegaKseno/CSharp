//Задача 67: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.Write("введите целое число ->");
int number = Convert.ToInt32(Console.ReadLine());
int NumberSum(int num)
{
    if (num != 0)
    {
        return num % 10 + NumberSum(num / 10);
    }
    return num;
}

Console.WriteLine(NumberSum(number));

