//Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int NaturalDegree(int numA, int numB)
{

    int temp = numA;
    for (int i = 0; i < numB - 1; i++)
    {
        temp = numA * temp;
    }
    return temp;
}

Console.Write("Введите первое число А-> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число B-> ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > 0 && numberB > 0)
{
    int result = NaturalDegree(numberA, numberB);
    Console.Write(numberA+", "+numberB+" -> "+result);
}
else
{
    Console.Write("Введено не корректное значение");
}

