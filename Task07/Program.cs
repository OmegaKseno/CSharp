//Напишите программу, которая на вход принемает
//трехзначное число и на выходе показывает последнюю цифру.
Console.Write("Insert the number ->");
int number = Convert.ToInt32(Console.ReadLine());
if(number<1000&number>99)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("Incorrect number entered");
}