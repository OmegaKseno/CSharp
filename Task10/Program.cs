//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
 //вторую цифру этого числа. Выполнить с помощью числовых операций 
 //(целочисленное деление, остаток от деления).
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введте трёхзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>100&&number<999)
{
int result = SecondDigit(number);
Console.WriteLine(number+ "  -> " +result);
}
else
{
    Console.WriteLine("Введено не корректное число");
}


int SecondDigit (int num)
{
 return (num/10)%10;   
}
