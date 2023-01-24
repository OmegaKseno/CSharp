Console.Write("Введите первое число А-> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число B-> ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA>0&&numberB>0)
{
Console.Write(NaturalDegree(numberA,numberB));
}
else
{
    Console.Write("Введено не корректное значение");
}

int NaturalDegree (int numA,int numB)
{
    
    int temp = numA;
    for (int i = 0; i < numB-1; i++)
    {
       temp =  numA*temp;
    }
    return temp;
}