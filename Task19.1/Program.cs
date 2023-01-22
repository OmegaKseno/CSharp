//Задача 19.1
//Напишите программу, которая принимает на вход  число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number+"->"+CheckPalindrome(number));


string CheckPalindrome (int num)
{   
string coup=""; 
   while(num>0)
   {
     coup+= Convert.ToString(num%10); 
     num = num/10;  
   }   
return coup == Convert.ToString(number)?"Да":"Нет";

}







