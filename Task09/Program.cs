//9. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10,100);
Console.WriteLine("случайное число 10-99 -> "+number);
int firstDigit = number/10;
//Console.WriteLine(firstDigit);
int secondDigit = number%10;
//Console.WriteLine(secondDigit);
if(firstDigit>secondDigit||firstDigit==secondDigit)
{
    Console.WriteLine("MAX = "+firstDigit);
}
else
{
  Console.WriteLine("MAX = "+secondDigit);  
}
int result = firstDigit>secondDigit ? firstDigit:secondDigit;
Console.WriteLine("MAX = ter"+result); 