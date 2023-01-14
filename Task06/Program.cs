//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Write("Insert the number -> ");
double Number = Convert.ToDouble(Console.ReadLine());
if(Number%2==0)
{
    Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");  
}