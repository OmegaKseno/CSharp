// Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
Console.Write("Enter the first number->");
double FirstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number->");
double SecondNumber = Convert.ToDouble(Console.ReadLine());
if(SecondNumber*SecondNumber==FirstNumber)
{
    Console.WriteLine("Yes! The number is the square of the second");
}
else
{
    Console.WriteLine("No! The number is not the square of the second");
}
