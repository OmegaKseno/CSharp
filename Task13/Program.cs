//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций 
//(целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
int temp;
if (number>100)
{
    temp = DigitCorrection(number);
    Console.WriteLine(number +" -> "+ temp);
}   
else 
{
    Console.WriteLine (number+" <- Отсутствует третья цифра");
}

int DigitCorrection(int dNum)
{
while(dNum>999)
{
    dNum = dNum/10;
}
return dNum%10;
}
 

 
