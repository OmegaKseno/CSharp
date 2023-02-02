//Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.
Console.Write("Введите длину треугольника A - >");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину треугольника B - >");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину треугольника C - >");
int c = Convert.ToInt32(Console.ReadLine());

bool CheckTryangle (int numA,int numB,int numC )
{

return numA<numB+numC&&numB<numA+numB&&numC<numB+numC;
}
bool result = CheckTryangle (a,b,c );
Console.Write(result?"Да":"Нет");