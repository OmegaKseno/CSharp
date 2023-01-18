//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру обозначающую день недели -> ");
int deyWeek = Convert.ToInt32(Console.ReadLine());
if (deyWeek>0&deyWeek<8)
{
bool result = CheckDayWeek(deyWeek);
Console.Write(result?"Да":"Нет");
}
else
{
    Console.WriteLine("Введенное значение не обозночает день недели!");
}

bool CheckDayWeek (int num)
{
    return num==7||num==6;
}

