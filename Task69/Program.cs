//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8
Console.Write("введите целое число  A->");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите целое число  B->");
int numberB = Convert.ToInt32(Console.ReadLine());
int MultiSum(int numA,int numB)
{
    if(numB==0) return 1;
    
     return numA * MultiSum( numA, numB-1);


}
int result = MultiSum(numberA,numberB);
Console.WriteLine(result);