//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EquationX (double b1,double k1,double b2,double k2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
}

double EquationY (double b1,double k1,double x)
{
    double y = k1*x+b1;
    return y;
}
Console.Write("Введите значение b1 ->");
double NumB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1 ->");
double NumK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 ->");
double NumB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 ->");
double NumK2 = Convert.ToDouble(Console.ReadLine());

if(NumK1==NumK2 && NumB1==NumB2)
{
Console.Write("Прямые совподают");
}
else if(NumK1==NumK2 || NumB1==NumB2)
{
 Console.Write("Прямые паралельны");   
}
else
{
double NumX = EquationX (NumB1,NumK1,NumB2,NumK2);
double NumY = EquationY (NumB2,NumK2,NumX);
Console.Write($"b1= {Math.Round(NumB1,1)}, k1= {Math.Round(NumK1,1)},"); 
Console.Write($" b2= {Math.Round(NumB2,1)}, k2= {Math.Round(NumK2,1)}->"); 
Console.Write($"{Math.Round(NumX,1)};{Math.Round(NumY,1)}");
}