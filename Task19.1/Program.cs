//Задача 19.1
//Напишите программу, которая принимает на вход  число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number+"->"+Check(number));


string Check (int num)
{   
string set="" ; 
while(num>0)
{
 set= set+ Convert.ToString(num%10); 
  num = num/10;  
}
return set == Convert.ToString(number)?"Да":"Нет";

}







