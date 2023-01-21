//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckQuarter(quarter));

 string CheckQuarter (int metQ )
{
 if (metQ==1)return "x>0,y>0";
 if (metQ==2)return "x>0,y<0";
 if (metQ==3)return "x<0,y<0";
 if (metQ==4)return "x<0,y>0";

 return "Введите корректные данные";
}