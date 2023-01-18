//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да
string MultiplicityCheck(int num)
{
string numChek = num%7==0&num%23==0 ? "Да":"Нет";
return numChek;
}

Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(MultiplicityCheck(number));

