//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
bool CheckPalindrome(int num)
{
    if( num%10==num/10000)
    {
        return (num/10)%10==(num/1000)%10;    
    }
    else
    {
        return false;
    }
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 9999&number<100000)
{
     string status = CheckPalindrome(number)==true?("Да"):("Нет");
     Console.WriteLine(number+" -> "+status);

}
else
{
     Console.WriteLine("Введено не корректное число");
}

