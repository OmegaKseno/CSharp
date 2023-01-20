//17. Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка.
Console.Write("Введите точки координат");
Console.WriteLine("X");
int coordinatePointX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точки координат");
Console.WriteLine("Y");
int coordinatePointY = Convert.ToInt32 (Console.ReadLine());
int quarter = CheckQuarter(coordinatePointX,coordinatePointY) ;
string resv = quarter>0?($"Вы ввели координаты четвети -> {quarter}"):("Введены не корректные данные");
Console.WriteLine(resv);


 int CheckQuarter (int x, int y )
{
 if (x>0&&y>0)return 1;
 if (x>0&&y<0)return 2;
 if (x<0&&y<0)return 3;
 if (x<0&&y>0)return 4;
 return 0;
}