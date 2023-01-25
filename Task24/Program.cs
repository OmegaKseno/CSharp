//24.
//Напишите программу которая, принимает на вход число А и выдает
//сумму чисел от 1 до а.
Console.Write("Введите число А -> ");
int number = Convert.ToInt32(Console.ReadLine());
int result=Summer(number);
Console.Write(number+"-> "+result);
int Summer(int num)
{
int sum=0;
for (int i = 1; i <= num; i++)
{
    sum = sum+i;
}
return sum;
}
