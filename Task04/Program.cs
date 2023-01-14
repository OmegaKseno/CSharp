//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the first number->  ");
double FirstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number->  ");
double SecondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number->  ");
double ThirdNumber = Convert.ToDouble(Console.ReadLine());
 
double Max = FirstNumber;
if(SecondNumber>Max)
{
    Max = SecondNumber;
}
 
 if (ThirdNumber>Max)
{
    Max = ThirdNumber;
}
Console.WriteLine(Max);
