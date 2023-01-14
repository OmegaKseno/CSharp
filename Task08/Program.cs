//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Insert the number ->");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while(counter <= number)
{
     if(counter%2==0)
       {
          Console.Write(counter+"|");
       }
     counter++;
}