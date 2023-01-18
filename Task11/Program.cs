//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int result = Delete(number);
Console.WriteLine(result );
int Delete(int num)
{
int first = (num/100)*10;
int second = num%10;
int deleteResult = first+second;
return deleteResult;
}




