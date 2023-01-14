//Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.

Console.Write("Insert the number-> ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0)
{
int negative = -number;
while(negative <= number)
{
    Console.Write(negative +",");
    negative++;
}
}
else
{
    Console.WriteLine("Entered non-natural number");
}


