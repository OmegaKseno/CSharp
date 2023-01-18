//12. Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если число 1 не кратно числу 2, то
//программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
int MultiDig (int num1,int num2)
{
int res = num1%num2;
return res;
}

Console.Write("Введите чило 1 ->  ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило 2 ->  ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
int result = MultiDig(firstDigit,secondDigit);
if (result==0)
{
 Console.WriteLine(firstDigit+" , "+secondDigit+", кратно.");   
}
else
{
Console.WriteLine(firstDigit+" , "+secondDigit+",не кратно, остаток "+result);
}







